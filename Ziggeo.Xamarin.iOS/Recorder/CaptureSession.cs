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
    internal class CaptureSession : AVCaptureVideoDataOutputSampleBufferDelegate, IAVCaptureAudioDataOutputSampleBufferDelegate, IAVCaptureMetadataOutputObjectsDelegate
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
        public event CaptureSessionEventDelegate RecordingDurationChanged;

        public delegate void CaptureSessionErrorDelegate(CaptureSession session, NSError error);
        public event CaptureSessionErrorDelegate RuntimeError;

        public delegate void CaptureSessionInterruptionDelegate(CaptureSession session, AVCaptureSessionInterruptionReason reason);
        public event CaptureSessionInterruptionDelegate Interrupted;
        public event CaptureSessionEventDelegate InterruptionEnded;

        public event CaptureSessionEventDelegate NotAuthorized;
        public event CaptureSessionEventDelegate ConfigurationFailed;
        public event CaptureSessionEventDelegate ConfigurationFinished;

        public delegate void CaptureSessionDoubleValueDelegate(CaptureSession session, double value);
        public event CaptureSessionDoubleValueDelegate LuminosityUpdated;
        public event CaptureSessionDoubleValueDelegate AudioLevelUpdated;
        public delegate void CaptureSessionFaceDelegate(CaptureSession session, CoreGraphics.CGRect rect, int faceID);
        public event CaptureSessionFaceDelegate FaceDetected;

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

        public AVCaptureAudioDataOutput AudioDataOutput
        {
            get;
            private set;
        }

        public AVCaptureVideoDataOutput VideoDataOutput
        {
            get;
            private set;
        }

        public AVCaptureMetadataOutput MetadataOutput
        {
            get;
            private set;
        }

        public AVAssetWriter MovieAssetWriter
        {
            get;
            private set;
        }

        public AVAssetWriterInput MovieAssetWriterAudioInput
        {
            get;
            private set;
        }

        public AVAssetWriterInput MovieAssetWriterVideoInput
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
                //return MovieOutput != null && MovieOutput.Recording;
                return (MovieAssetWriter != null && MovieAssetWriter.Status == AVAssetWriterStatus.Writing);
            }
        }

        public CapturePreviewView PreviewView
        {
            get;
            private set;
        }

        private bool FirstSampleRendered
        {
            get;
            set;
        }

        private double FirstSampleTimestamp
        {
            get;
            set;
        }

        public double Duration
        {
            get;
            set;
        }

        private bool DurationExceeded
        {
            get;
            set;
        }

        public bool AutostartEnabled
        {
            get;
            set;
        }

        public double MaxDuration
        {
            get;
            set;
        }

        public VideoQuality Quality
        {
            get;
            set;
        }

        public void SetupDataOutputs()
        {
            AudioDataOutput = new AVCaptureAudioDataOutput();
            AudioDataOutput.SetSampleBufferDelegateQueue(this, SessionQueue);
            Session.AddOutput(AudioDataOutput);
            Console.WriteLine("asset audio capture output added");

            VideoDataOutput = new AVCaptureVideoDataOutput();
            VideoDataOutput.AlwaysDiscardsLateVideoFrames = true;
            VideoDataOutput.SetSampleBufferDelegateQueue(this, SessionQueue);
            Session.AddOutput(VideoDataOutput);
            AVCaptureConnection connection = VideoDataOutput.ConnectionFromMediaType(AVMediaType.Video);
            if(connection != null)
            {
                if (connection.SupportsVideoStabilization) connection.PreferredVideoStabilizationMode = AVCaptureVideoStabilizationMode.Auto;
                connection.VideoMirrored = GetCurrentCameraPosition() == AVCaptureDevicePosition.Front;
            }
            Console.WriteLine("asset video capture output added");
        }

        public void SetupMetadataOutput()
        {
            MetadataOutput = new AVCaptureMetadataOutput();
            if (Session.CanAddOutput(MetadataOutput))
            {
                Session.AddOutput(MetadataOutput);
            }
            MetadataOutput.SetDelegate(this, DispatchQueue.MainQueue);
            MetadataOutput.MetadataObjectTypes = AVMetadataObjectType.Face;
        }

        public void UpdateOrientation(UIDeviceOrientation orientation)
        {
            //UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;

            if (orientation.IsLandscape() || orientation.IsPortrait())
			{
                Session?.BeginConfiguration();
                AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
				if (previewLayer != null)
				{
                    previewLayer.Connection.VideoOrientation = (AVCaptureVideoOrientation)orientation;
                    AVCaptureConnection connection = VideoDataOutput?.ConnectionFromMediaType(AVMediaType.Video);
                    if (connection != null)
                    {
                        connection.VideoOrientation = previewLayer.Connection.VideoOrientation;
                    }
                }
                Session?.CommitConfiguration();
			}
		}

        public int GetWidth()
        {
            AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
            switch (previewLayer.Connection.VideoOrientation)
            {
                case AVCaptureVideoOrientation.LandscapeLeft:
                case AVCaptureVideoOrientation.LandscapeRight:
                    return 1920;
                case AVCaptureVideoOrientation.Portrait:
                case AVCaptureVideoOrientation.PortraitUpsideDown:
                    return 1080;
            }
            return 1920;
        }

        public int GetHeight()
        {
            AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
            switch (previewLayer.Connection.VideoOrientation)
            {
                case AVCaptureVideoOrientation.LandscapeLeft:
                case AVCaptureVideoOrientation.LandscapeRight:
                    return 1080;
                case AVCaptureVideoOrientation.Portrait:
                case AVCaptureVideoOrientation.PortraitUpsideDown:
                    return 1920;
            }
            return 1080;
        }

        public string SetupAssetWriter()
        {
            string outputFilename = NSProcessInfo.ProcessInfo.GloballyUniqueString;
            string[] paths = NSSearchPath.GetDirectories(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User, true);
            if (paths == null || paths.Length == 0) throw new InvalidOperationException("no document directory found");
            string documentsDirectory = paths[0];
            string outputFilePath = System.IO.Path.Combine(documentsDirectory, string.Format("{0}.mp4", outputFilename));
            MovieAssetWriter = new AVAssetWriter(NSUrl.FromFilename(outputFilePath), AVFileType.Mpeg4, out NSError error);
            if (error != null)
            {
                Console.WriteLine("asset writer error: {0}", error);
            }
            AudioToolbox.AudioChannelLayout channelLayout = new AudioToolbox.AudioChannelLayout
            {
                AudioTag = AudioToolbox.AudioChannelLayoutTag.Stereo
            };
            var audioSettings = NSDictionary.FromObjectsAndKeys(
                new NSObject[] { new NSNumber((uint)AudioToolbox.AudioFormatType.MPEG4AAC), new NSNumber(44100.0), new NSNumber(2), new NSNumber(128000)/*, channelLayout.AsData()*/},
                new NSObject[] { AVAudioSettings.AVFormatIDKey, AVAudioSettings.AVSampleRateKey, AVAudioSettings.AVNumberOfChannelsKey, AVAudioSettings.AVEncoderBitRateKey/*, AVAudioSettings.AVChannelLayoutKey*/ }
            );
            MovieAssetWriterAudioInput = new AVAssetWriterInput(AVMediaType.Audio, new AudioSettings(audioSettings));
            MovieAssetWriterAudioInput.ExpectsMediaDataInRealTime = true;
            MovieAssetWriter.AddInput(MovieAssetWriterAudioInput);

            var videoSettings = NSDictionary.FromObjectsAndKeys(
               new NSObject[] { AVVideo.CodecH264, new NSNumber(GetWidth()), new NSNumber(GetHeight()) },
               new NSObject[] { AVVideo.CodecKey, AVVideo.WidthKey, AVVideo.HeightKey }
            );
            MovieAssetWriterVideoInput = new AVAssetWriterInput(AVMediaType.Video, new AVVideoSettingsCompressed(videoSettings));
            MovieAssetWriterVideoInput.ExpectsMediaDataInRealTime = true;
            if(MovieAssetWriter.CanAddInput(MovieAssetWriterVideoInput))
            {
                MovieAssetWriter.AddInput(MovieAssetWriterVideoInput);
                Console.WriteLine("video input successfully added");
            }
            else
            {
                Console.WriteLine("video input can't be added");
            }
            return outputFilePath;
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

                    SetupMetadataOutput();
                    SetupDataOutputs();


                    //this.MovieOutput = new AVCaptureMovieFileOutput();
                    //if (Session.CanAddOutput(MovieOutput))
                    //{
                    //    Session.AddOutput(MovieOutput);
                    //    AVCaptureConnection connection = MovieOutput.ConnectionFromMediaType(AVMediaType.Video);
                    //    if (connection.SupportsVideoStabilization) connection.PreferredVideoStabilizationMode = AVCaptureVideoStabilizationMode.Auto;
                    //}
                    //else
                    //{
                    //    Console.WriteLine("failed to add movie output to the session");
                    //    SetupResult = SessionSetupResult.Failed;
                    //    return;
                    //}

                    Session.CommitConfiguration();
                    ConfigurationFinished?.Invoke(this);
                });
            }
            catch (Exception ex)
            {
                DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
            }
        }

        private void MeasureLuminosity(CMSampleBuffer sampleBuffer)
        {
            var attachments = sampleBuffer.GetAttachments(CMAttachmentMode.ShouldPropagate);
            if (attachments.TryGetValue(ImageIO.CGImageProperties.ExifDictionary, out NSObject exifMetadata))
            {
                if (exifMetadata is NSDictionary exif)
                {
                    if (exif.TryGetValue(ImageIO.CGImageProperties.ExifBrightnessValue, out NSObject brightness))
                    {
                        if (brightness is NSNumber brightnessNumber)
                        {
                            LuminosityUpdated?.Invoke(this, brightnessNumber.DoubleValue);
                        }
                    }
                }
            }
        }

        private void MeasureAudioLevel(CMSampleBuffer sampleBuffer)
        {
            CMBlockBuffer blockBuffer = sampleBuffer.GetDataBuffer();
            int dataLength = (int)blockBuffer.DataLength;
            NSMutableData data = NSMutableData.FromLength(dataLength);
            blockBuffer.CopyDataBytes(0, (uint)dataLength, data.MutableBytes);

            double sum = 0;
            int count = 0;
            int sampleCount = (int)sampleBuffer.NumSamples;
            unsafe
            {
                short* samples = (short*)data.MutableBytes;
                for (int i = 0; i < sampleCount; i++)
                {
                    sum += Math.Abs(*samples);
                    samples++;
                    count++;
                }
            }
            //Console.WriteLine("samples count: {0}, data length: {1}, sum: {2}", sampleCount, dataLength, sum);
            if (count > 0) sum /= (double)count;
            double level = sum / 10000.0;
            if (level > 1) level = 1;
            AudioLevelUpdated?.Invoke(this, level);
            data.Dispose();
            blockBuffer.Dispose();
        }

        public override void DidOutputSampleBuffer(AVCaptureOutput captureOutput, CMSampleBuffer sampleBuffer, AVCaptureConnection connection)
        {
            if(captureOutput == VideoDataOutput)
            {
                MeasureLuminosity(sampleBuffer);
                double currentTimestamp = sampleBuffer.PresentationTimeStamp.Seconds;
                if (MovieAssetWriter != null && !DurationExceeded)
                {
                    if(MovieAssetWriter.Status == AVAssetWriterStatus.Unknown)
                    {
                        MovieAssetWriter.StartWriting();
                        MovieAssetWriter.StartSessionAtSourceTime(sampleBuffer.PresentationTimeStamp);
                        Console.WriteLine("asset writing started");
                        FirstSampleTimestamp = currentTimestamp;
                    }
                    if(MovieAssetWriter.Status == AVAssetWriterStatus.Failed)
                    {
                        Console.WriteLine("movie asset writer failed");
                    }
                    else
                    {
                        if(MovieAssetWriterVideoInput != null && MovieAssetWriterVideoInput.ReadyForMoreMediaData)
                        {
                            MovieAssetWriterVideoInput?.AppendSampleBuffer(sampleBuffer);
                            FirstSampleRendered = true;
                        }
                        if(MaxDuration > 0 && Math.Abs(currentTimestamp - FirstSampleTimestamp) >= MaxDuration)
                        {
                            DurationExceeded = true;
                            StopRecording();
                        }
                    }
                    Duration = currentTimestamp - FirstSampleTimestamp;
                    RecordingDurationChanged?.Invoke(this);
                }
            }
            else if(captureOutput == AudioDataOutput)
            {
                MeasureAudioLevel(sampleBuffer);
                if (FirstSampleRendered && MovieAssetWriterAudioInput != null && MovieAssetWriterAudioInput.ReadyForMoreMediaData)
                {
                    MovieAssetWriterAudioInput?.AppendSampleBuffer(sampleBuffer);
                }
            }
            sampleBuffer.Dispose();
        }

        [Export("captureOutput:didOutputMetadataObjects:fromConnection:")]
        public void DidOutputMetadataObjects(AVCaptureMetadataOutput captureOutput, AVMetadataObject[] metadataObjects, AVCaptureConnection connection)
        {
            AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
            foreach(var obj in metadataObjects)
            {
                if(obj.Type == AVMetadataObjectType.Face)
                {
                    if (previewLayer.GetTransformedMetadataObject(obj) is AVMetadataFaceObject face)
                    {
                        var rect = face.Bounds;
                        int id = (int)face.FaceID;
                        FaceDetected?.Invoke(this, rect, id);
                    }
                }
                obj.Dispose();
            }
        }

        public AVCaptureDevicePosition GetCurrentCameraPosition()
        {
            if (VideoInput == null || VideoInput.Device == null) return AVCaptureDevicePosition.Unspecified;
            return VideoInput.Device.Position;
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

                    AVCaptureConnection connection = VideoDataOutput.ConnectionFromMediaType(AVMediaType.Video);
                    if(connection.SupportsVideoStabilization)
                    {
                        connection.PreferredVideoStabilizationMode = AVCaptureVideoStabilizationMode.Auto;
                    }
                    connection.VideoMirrored = (preferredPosition == AVCaptureDevicePosition.Front);
                    Session.CommitConfiguration();
                    DispatchQueue.MainQueue.DispatchAsync(() =>
                    {
                        UpdateOrientation((UIDeviceOrientation)UIApplication.SharedApplication.StatusBarOrientation);
                    });
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
                            Console.WriteLine("session started");
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
                        Console.WriteLine("session stopped");
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
                        //AVCaptureConnection connection = MovieOutput.ConnectionFromMediaType(AVMediaType.Video);
                        //AVCaptureVideoPreviewLayer previewLayer = (AVCaptureVideoPreviewLayer)PreviewView?.Layer;
                        //if (previewLayer != null && connection != null)
                        //{
                        //    connection.VideoOrientation = previewLayer.Connection.VideoOrientation;
                        //}
                        DispatchQueue.MainQueue.DispatchAsync(() =>
                        {
                            UpdateOrientation((UIDeviceOrientation)UIApplication.SharedApplication.StatusBarOrientation);
                        });
                        SetFlashMode(AVCaptureFlashMode.Off, VideoInput.Device);
                        Duration = 0;
                        DurationExceeded = false;
                        SetupAssetWriter();
                        FirstSampleRendered = false;
                        //Random rnd = new Random();
                        //string outputFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), string.Format("{0}.mov", NSProcessInfo.ProcessInfo.GloballyUniqueString));
                        //MovieOutput.StartRecordingToOutputFile(NSUrl.CreateFileUrl(new[] { outputFileName }), this);
                    }
                }
				catch (Exception ex)
				{
                    Console.WriteLine("start recorder error: {0}", ex.ToString());
					DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
				}
			});
        }

        public void StopRecording()
        {
            Console.WriteLine("stop recording call");
            SessionQueue?.DispatchAsync(async () =>
            {
                try
                {
                    if (RecordingNow)
                    {
                        //MovieOutput?.StopRecording();
                        MovieAssetWriterAudioInput = null;
                        MovieAssetWriterVideoInput = null;
                        NSUrl outputUrl = MovieAssetWriter.OutputURL;
                        await MovieAssetWriter.FinishWritingAsync();
                        MovieAssetWriter = null;
                        Duration = 0;
                        FinishedRecording(outputUrl, null);
                    }
                }
                catch (Exception ex)
                {
                    DispatchQueue.MainQueue.DispatchAsync(() => RuntimeError?.Invoke(this, new NSError(new NSString(ex.Message), -1)));
                }
			});
        }

        //private void FinishedRecording(AVCaptureFileOutput captureOutput, NSUrl outputFileUrl, NSObject[] connections, NSError error)
        //     {
        //Console.WriteLine("finished recording call");
        //    if(error != null && (error.UserInfo[AVErrorKeys.RecordingSuccessfullyFinished] as NSNumber !=null) && !(error.UserInfo[AVErrorKeys.RecordingSuccessfullyFinished] as NSNumber).BoolValue)
        //    {
        //        RuntimeError?.Invoke(this, error);
        //    }
        //    RecordingFinished?.Invoke(this, outputFileUrl);
        //}
        private void FinishedRecording(NSUrl outputFileUrl, NSError error)
        {
            Console.WriteLine("finished recording call");
            if (error != null)
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
