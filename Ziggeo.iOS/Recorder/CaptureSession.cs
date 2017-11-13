using System;
using System.Collections.Generic;
using AVFoundation;
using CoreMedia;
using CoreFoundation;
using UIKit;
using Foundation;
using System.Linq;

namespace Ziggeo
{
    internal class CaptureSession : NSObject, IAVCaptureFileOutputRecordingDelegate
    {
        public enum SessionSetupResult
        {
            NotFinished,
            Success,
            NotAuthorized,
            Failed
        }

        public delegate void CaptureSessionEventDelegate(CaptureSession session);
        public event CaptureSessionEventDelegate RunningStateChanged;
        public event CaptureSessionEventDelegate SubjectAreaDidChange;

        public delegate void CaptureSessionErrorDelegate(CaptureSession session, NSError error);
        public event CaptureSessionErrorDelegate RuntimeError;

        public delegate void CaptureSessionInterruptionDelegate(CaptureSession session, AVCaptureSessionInterruptionReason reason);
        public event CaptureSessionInterruptionDelegate Interrupted;
        public event CaptureSessionEventDelegate InterruptionEnded;

        public event CaptureSessionEventDelegate NotAuthorized;
        public event CaptureSessionEventDelegate ConfigurationFailed;
        public event CaptureSessionEventDelegate ConfigurationFinished;

        public delegate void CaptureSessionRecordingFinishedDelegate(CaptureSession session, NSUrl outputFile);
        public event CaptureSessionRecordingFinishedDelegate RecordingFinished;

        public CaptureSession(CapturePreviewView previewView)
        {
            this.PreviewView = previewView;
            this.SessionQueue = new DispatchQueue("capture queue", false);
            this.SetupResult = SessionSetupResult.NotFinished;
            this.CaptureDevicePosition = AVCaptureDevicePosition.Back;
        }

        public AVCaptureSession Session
        {
            get;
            private set;
        }

        public DispatchQueue SessionQueue
        {
            get;
            private set;
        }

        public SessionSetupResult SetupResult
        {
            get;
            private set;
        }

        public AVCaptureDevicePosition CaptureDevicePosition
        {
            get;
            set;
        }

        public AVCaptureDeviceInput VideoInput
        {
            get;
            private set;
        }

        public AVCaptureMovieFileOutput MovieOutput
        {
            get;
            private set;
        }

        public bool Running
        {
            get;
            private set;
        }

        private List<NSObject> Observers
        {
            get;
            set;
        }

        private IDisposable RunningStartedObserver
        {
            get;
            set;
        }

		public bool RecordingNow
        {
            get
            {
                return MovieOutput != null && MovieOutput.Recording;
            }
        }

        public CapturePreviewView PreviewView
        {
            get;
            private set;
        }

        public void UpdateOrientation(UIDeviceOrientation orientation)
        {
			if (orientation.IsLandscape() || orientation.IsPortrait())
			{
				AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
				if (previewLayer != null)
				{
                    previewLayer.Connection.VideoOrientation = (AVCaptureVideoOrientation)orientation;
				}
			}
		}

        public void Setup()
        {
            try
            {
                Session = new AVCaptureSession();
                Session.AutomaticallyConfiguresApplicationAudioSession = false;

                if (PreviewView != null) PreviewView.Session = Session;

                var status = AVCaptureDevice.GetAuthorizationStatus(AVMediaType.Video);
                SetupResult = SessionSetupResult.Success;
                switch (status)
                {
                    case AVAuthorizationStatus.Authorized: break;
                    case AVAuthorizationStatus.NotDetermined:
                        SessionQueue.Suspend();
                        AVCaptureDevice.RequestAccessForMediaType(AVMediaType.Video, (accessGranted) =>
                        {
                            if (!accessGranted) SetupResult = SessionSetupResult.NotAuthorized;
                        });
                        SessionQueue.Resume();
                        break;
                    default: SetupResult = SessionSetupResult.NotAuthorized; break;
                }
                SessionQueue.DispatchAsync(() =>
                {
                    if (SetupResult != SessionSetupResult.Success) return;
                    AVCaptureDevice videoDevice = GetCaptureDevice(AVMediaTypes.Video, CaptureDevicePosition);
                    NSError error;
                    AVCaptureDeviceInput videoInput = new AVCaptureDeviceInput(videoDevice, out error);
                    if (videoInput == null)
                    {
                        Console.WriteLine("failed to create video input: {0}", error);
                        SetupResult = SessionSetupResult.Failed;
                        return;
                    }
                    Session.BeginConfiguration();
                    if (Session.CanAddInput(videoInput))
                    {
                        Session.AddInput(videoInput);
                        this.VideoInput = videoInput;
                        DispatchQueue.MainQueue.DispatchAsync(() =>
                        {
                            UIInterfaceOrientation statusBarOrientation = UIApplication.SharedApplication.StatusBarOrientation;
                            AVCaptureVideoOrientation initialVideoOrientation = AVCaptureVideoOrientation.Portrait;
                            if (statusBarOrientation != UIInterfaceOrientation.Unknown)
                            {
                                initialVideoOrientation = (AVCaptureVideoOrientation)statusBarOrientation;
                            }
                            AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
                            if (previewLayer != null)
                            {
                                previewLayer.Connection.VideoOrientation = initialVideoOrientation;
                            }
                        });
                    }
                    else
                    {
                        Console.WriteLine("Failed to add video input to the session");
                        SetupResult = SessionSetupResult.Failed;
                        return;
                    }

                    AVCaptureDevice audioDevice = AVCaptureDevice.GetDefaultDevice(AVMediaType.Audio);
                    AVCaptureDeviceInput audioInput = new AVCaptureDeviceInput(audioDevice, out error);
                    if (audioInput == null)
                    {
                        Console.WriteLine("failed to create audio input: {0}", error);
                        SetupResult = SessionSetupResult.Failed;
                        return;
                    }
                    if (Session.CanAddInput(audioInput))
                    {
                        Session.AddInput(audioInput);
                    }
                    else
                    {
                        Console.WriteLine("failed to add audio input to the session");
                        SetupResult = SessionSetupResult.Failed;
                        return;
                    }
                    this.MovieOutput = new AVCaptureMovieFileOutput();
                    if (Session.CanAddOutput(MovieOutput))
                    {
                        Session.AddOutput(MovieOutput);
                        AVCaptureConnection connection = MovieOutput.ConnectionFromMediaType(AVMediaType.Video);
                        if (connection.SupportsVideoStabilization) connection.PreferredVideoStabilizationMode = AVCaptureVideoStabilizationMode.Auto;
                    }
                    else
                    {
                        Console.WriteLine("failed to add movie output to the session");
                        SetupResult = SessionSetupResult.Failed;
                        return;
                    }

                    Session.CommitConfiguration();
                    ConfigurationFinished?.Invoke(this);
                });
            }
            catch (Exception ex)
            {
                DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
            }
        }

        public void ChangeCamera()
        {
            SessionQueue.DispatchAsync(() =>
            {
                try
                {
                    AVCaptureDevice currentVideoDevice = VideoInput.Device;
                    AVCaptureDevicePosition preferredPosition = AVCaptureDevicePosition.Unspecified;
                    AVCaptureDevicePosition currentPosition = currentVideoDevice.Position;
                    switch(currentPosition)
                    {
                        case AVCaptureDevicePosition.Unspecified:
                        case AVCaptureDevicePosition.Front:
                            preferredPosition = AVCaptureDevicePosition.Back;
                            break;
                        case AVCaptureDevicePosition.Back:
                            preferredPosition = AVCaptureDevicePosition.Front;
                            break;
                    }

                    AVCaptureDevice videoDevice = GetCaptureDevice(AVMediaTypes.Video, preferredPosition);
                    AVCaptureDeviceInput videoDeviceInput = AVCaptureDeviceInput.FromDevice(videoDevice);
                    Session.BeginConfiguration();
                    Session.RemoveInput(this.VideoInput);
                    if (Session.CanAddInput(videoDeviceInput))
                    {
                        NSNotificationCenter.DefaultCenter.RemoveObserver(Observers.FirstOrDefault());
                        SetFlashMode(AVCaptureFlashMode.Auto, videoDevice);
                        if (Observers.Count() > 0)
                        {
                            Observers[0] = NSNotificationCenter.DefaultCenter.AddObserver(
                                AVCaptureDevice.SubjectAreaDidChangeNotification,
                                (NSNotification notification) => ProcessSubjectAreaDidChange(notification),
                                VideoInput?.Device);
                        }
						Session.AddInput(videoDeviceInput);
                        this.VideoInput = videoDeviceInput;
                    }
                    else Session.AddInput(VideoInput);

                    AVCaptureConnection connection = MovieOutput.ConnectionFromMediaType(AVMediaType.Video);
                    if(connection.SupportsVideoStabilization)
                    {
                        connection.PreferredVideoStabilizationMode = AVCaptureVideoStabilizationMode.Auto;
                    }
                    Session.CommitConfiguration();
                }
                catch (Exception ex)
                {
                    DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
                }
            });
		}

        private void AddObservers()
        {
            RemoveObservers();
            if (Observers == null) Observers = new List<NSObject>();
            RunningStartedObserver = Session.AddObserver("running", Foundation.NSKeyValueObservingOptions.New, (obj) =>
            {
                DispatchQueue.MainQueue.DispatchAsync(()=>ProcessRunningStateChanged());
            });
			Observers.Add(NSNotificationCenter.DefaultCenter.AddObserver(
                AVCaptureDevice.SubjectAreaDidChangeNotification,
                (NSNotification notification) => ProcessSubjectAreaDidChange(notification), 
                VideoInput?.Device));
            Observers.Add(NSNotificationCenter.DefaultCenter.AddObserver(
                AVCaptureSession.RuntimeErrorNotification,
                (NSNotification notification) => ProcessRuntimeError(notification),
                Session));
            Observers.Add(NSNotificationCenter.DefaultCenter.AddObserver(
                AVCaptureSession.WasInterruptedNotification,
				(NSNotification notification) => ProcessSessionInterrupted(notification),
                Session));
            Observers.Add(NSNotificationCenter.DefaultCenter.AddObserver(
                AVCaptureSession.InterruptionEndedNotification,
				(NSNotification notification) => ProcessSessionInterruptionEnded(notification),
                Session));
		}

        private void RemoveObservers()
        {
            if(Observers != null) NSNotificationCenter.DefaultCenter.RemoveObservers(Observers);
            Observers = null;
            RunningStartedObserver?.Dispose();
            RunningStartedObserver = null;
        }

        private void ProcessSubjectAreaDidChange(NSNotification notification)
        {
            SubjectAreaDidChange?.Invoke(this);
        }

        private void ProcessRunningStateChanged()
        {
            this.Running = Session != null && Session.Running;
            RunningStateChanged?.Invoke(this);   
        }

        public void Start()
        {
            SessionQueue?.DispatchAsync(() =>
            {
                switch (SetupResult)
                {
                    case SessionSetupResult.Success:
                        if (Observers == null || Observers.Count == 0) AddObservers();
                        try
                        {
                            Session.StartRunning();
                            this.Running = Session.Running;
                        }
                        catch(Exception ex)
                        {
                            DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
                        }
                        break;
                    case SessionSetupResult.NotAuthorized:
                        DispatchQueue.MainQueue.DispatchAsync(() => NotAuthorized?.Invoke(this));
                        break;
                    case SessionSetupResult.Failed:
                        DispatchQueue.MainQueue.DispatchAsync(() => ConfigurationFailed?.Invoke(this));
                        break;
                    default: break;
                }

            });
        }

        public void Stop()
        {
            SessionQueue?.DispatchAsync(() =>
            {
                try
                {
                    if (SetupResult == SessionSetupResult.Success)
                    {
                        Session?.StopRunning();
                        RemoveObservers();
                    }
                }
				catch (Exception ex)
				{
					DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
				}
			});
        }

        public void StartRecording()
        {
            SessionQueue?.DispatchAsync(() =>
            {
                try
                {
                    if (!RecordingNow && Running)
                    {
                        AVCaptureConnection connection = MovieOutput.ConnectionFromMediaType(AVMediaType.Video);
                        AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
                        if (previewLayer != null && connection != null)
                        {
                            connection.VideoOrientation = previewLayer.Connection.VideoOrientation;
                        }

                        SetFlashMode(AVCaptureFlashMode.Off, VideoInput.Device);
                        Random rnd = new Random();
                        string outputFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), string.Format("{0}.mov", NSProcessInfo.ProcessInfo.GloballyUniqueString));
                        MovieOutput.StartRecordingToOutputFile(NSUrl.CreateFileUrl(new[] { outputFileName }), this);
                    }
                }
				catch (Exception ex)
				{
					DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
				}
			});
        }

        public void StopRecording()
        {
            Console.WriteLine("stop recording call");
            SessionQueue?.DispatchAsync(() =>
            {
                try
                {
                    if (RecordingNow)
                    {
                        MovieOutput?.StopRecording();
                    }
                }
                catch (Exception ex)
                {
                    DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
                }
			});
        }

		public void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError error)
        {
			Console.WriteLine("finished recording call");
            if(error != null && (error.UserInfo[AVErrorKeys.RecordingSuccessfullyFinished] as NSNumber !=null) && !(error.UserInfo[AVErrorKeys.RecordingSuccessfullyFinished] as NSNumber).BoolValue)
            {
                RuntimeError?.Invoke(this, error);
            }
            RecordingFinished?.Invoke(this, outputFileUrl);
        }

		private void ProcessRuntimeError(NSNotification notification)
        {
            NSError error = (NSError)notification.UserInfo[AVCaptureSession.ErrorKey];
            if(error != null)
            {
                Console.WriteLine("capture session runtime error: {0}", error);
                if ((long)error.Code == (long)AVError.MediaServicesWereReset)
                {
                    if (Running)
                    {
                        Start();
                    }
                }
                else RuntimeError?.Invoke(this, error);
            }
        }

        public void SetFlashMode(AVCaptureFlashMode mode, AVCaptureDevice device)
        {
            if (device.HasFlash && device.IsFlashModeSupported(mode))
            {
                NSError error;
                if(device.LockForConfiguration(out error))
                {
                    device.FlashMode = mode;
                    device.UnlockForConfiguration();
                }
            }
        }

        public void Focus(AVCaptureFocusMode focusMode, AVCaptureExposureMode exposureMode, CoreGraphics.CGPoint point, bool monitorSubjectAreaChange)
        {
			SessionQueue?.DispatchAsync(() =>
			{
				try
				{
                    AVCaptureDevice device = VideoInput.Device;
                    NSError error = null;
                    if (device != null && device.LockForConfiguration(out error))
                    {
                        if (device.FocusPointOfInterestSupported && device.IsFocusModeSupported(focusMode))
                        {
                            device.FocusPointOfInterest = point;
                            device.FocusMode = focusMode;
                        }
                        if (device.ExposurePointOfInterestSupported && device.IsExposureModeSupported(exposureMode))
                        {
                            device.ExposurePointOfInterest = point;
                            device.ExposureMode = exposureMode;
                        }
                        device.SubjectAreaChangeMonitoringEnabled = monitorSubjectAreaChange;
                        device.UnlockForConfiguration();
                    }
                    else throw new InvalidOperationException("can't lock device for configuration: " + error?.ToString());
                }
				catch (Exception ex)
				{
					DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
				}
			});
		}

        private void ProcessSessionInterrupted(NSNotification notification)
        {
            AVCaptureSessionInterruptionReason reason = (AVCaptureSessionInterruptionReason)(notification.UserInfo[AVCaptureSession.InterruptionReasonKey] as NSNumber).Int64Value;
            Interrupted?.Invoke(this, reason);
        }

		private void ProcessSessionInterruptionEnded(NSNotification notification)
		{
            InterruptionEnded?.Invoke(this);
		}

		private AVCaptureDevice GetCaptureDevice(AVMediaTypes mediaType, AVCaptureDevicePosition position)
        {
            AVCaptureDeviceDiscoverySession session = AVCaptureDeviceDiscoverySession.Create(new[]{
                AVCaptureDeviceType.BuiltInDualCamera,
                AVCaptureDeviceType.BuiltInMicrophone,
                AVCaptureDeviceType.BuiltInTelephotoCamera,
                AVCaptureDeviceType.BuiltInWideAngleCamera
            }, mediaType == AVMediaTypes.Audio ? AVMediaType.Audio : AVMediaType.Video, position);
            return (session.Devices.Length > 0) ? session.Devices[0] : null;
        }
    }
}
