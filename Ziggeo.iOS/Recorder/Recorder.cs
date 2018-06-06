using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIKit;
using Foundation;
using CoreFoundation;
using AVFoundation;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public partial class Recorder : UIViewController, IZiggeoRecorder
    {
        public delegate void VideoUploadCompleteDelegate(string token);
        public event VideoUploadCompleteDelegate OnVideoUploadComplete = null;

        public delegate void VideoRecordingCanceledDelegate();
        public event VideoRecordingCanceledDelegate OnVideoRecordingCanceled = null;

        public delegate void ZiggeoRecorderErrorDelegate(Exception ex);
        public event ZiggeoRecorderErrorDelegate OnRecorderError = null;

        public Recorder(IZiggeoApplication ziggeoApplication) : base("Recorder", null)
        {
			this.BackgroundRecordingID = UIApplication.BackgroundTaskInvalid;
            this.ZiggeoApplication = ziggeoApplication;
		}

        private CaptureSession CaptureSession
        {
            get;
            set;
        }

		public nint BackgroundRecordingID
		{
			get;
			private set;
		}

        public IZiggeoApplication ZiggeoApplication
        {
            get;
            private set;
        }

        private UITapGestureRecognizer FocusTapGesture
        {
            get;
            set;
        }

        public bool CoverSelectorEnabled
        {
            get;
            set;
        }

		public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            PreviewView.UserInteractionEnabled = true;
            FocusTapGesture = new UITapGestureRecognizer(() =>
            {
                if (CaptureSession != null)
                {
                    CoreGraphics.CGPoint devicePoint = (PreviewView.Layer as AVFoundation.AVCaptureVideoPreviewLayer).CaptureDevicePointOfInterestForPoint(FocusTapGesture.LocationInView(FocusTapGesture.View));
                    CaptureSession.Focus(AVFoundation.AVCaptureFocusMode.AutoFocus, AVFoundation.AVCaptureExposureMode.AutoExpose, devicePoint, true);
                }
            });
            PreviewView.AddGestureRecognizer(FocusTapGesture);

            UpdateUIChangingStateNow();
            try
            {
                CaptureSession = new CaptureSession(PreviewView);
                CaptureSession.CaptureDevicePosition = (VideoDevice == ZiggeoVideoDevice.Front ? AVCaptureDevicePosition.Front : AVCaptureDevicePosition.Back);
                CaptureSession.ConfigurationFailed += (session) =>
                {
                    UpdateUIFailedState();
                    Alert("error", "unable to capture video");
                };
                CaptureSession.ConfigurationFinished += (session) =>
                {
                    if (CaptureSession.SetupResult == CaptureSession.SessionSetupResult.Success) 
                    {
                        UpdateUIInitializedOK();   
                    }
                    else UpdateUIFailedState();
                };
                CaptureSession.NotAuthorized += (session) =>
                {
                    UIAlertAction cancel = UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null);
                    UIAlertAction settings = UIAlertAction.Create("Settings", UIAlertActionStyle.Default, (obj) =>
                    {
                        UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
                    });
					UpdateUIFailedState();
					Alert("error", "The application doesn't have permission to use the camera, please change privacy settings", new[] { cancel, settings });
                };
                CaptureSession.RuntimeError += (session, error) => 
                {
                    UpdateUIFailedState();
                    Alert("error", error.Domain);
                    OnRecorderError?.Invoke(new Exception(error.Description));
                };
                CaptureSession.RecordingFinished += (session, outputFile) => 
                {
                    Console.WriteLine("recording finished: " + outputFile);
                    UpdateUIRecordingStopped();
                    DispatchQueue.MainQueue.DispatchAsync(() =>
                    {
                        StartVideoProcessorChain(outputFile);
                    });
                };
                CaptureSession.RunningStateChanged += (session) => {
                    Console.WriteLine("running state changed: " + session.Running);
                };
                CaptureSession.SubjectAreaDidChange += (session) => {
                    Console.WriteLine("subject area did change");
                    CaptureSession?.Focus(AVFoundation.AVCaptureFocusMode.ContinuousAutoFocus, AVFoundation.AVCaptureExposureMode.ContinuousAutoExposure, new CoreGraphics.CGPoint(0.5, 0.5), false);
                };
                CaptureSession.Setup();
            }
            catch(Exception ex)
            {
                UpdateUIFailedState();
                Alert("error", ex.ToString());
                OnRecorderError?.Invoke(ex);
            }
        }

        protected virtual void StartVideoProcessorChain(NSUrl fileName)
        {
            VideoItem item = new VideoItem(fileName);
            VideoProcessor preview = new PreviewAndUpload(item);
            preview.Done += async (processor) => {
                try
                {
                    DismissViewController(true, null);
                    Console.WriteLine("processing done, file: {0}, cover: {1}", item.FilePath, item.Cover != null);

                    VideoConverter converter = new VideoConverter(item.FilePath.Path);
                    Console.WriteLine("converting started");
                    string convertedVideo = await converter.Convert(AVAssetExportSessionPreset.MediumQuality.GetConstant());
                    Console.WriteLine("converting complete");

                    Console.WriteLine("uploading...");
                    var video = await ZiggeoApplication.Videos.Create(convertedVideo, AdditionalParameters);
                    string videoToken = video["video"]["token"].Value<string>();
                    Console.WriteLine("uploading done: {0}", videoToken);
                    OnVideoUploadComplete?.Invoke(videoToken);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    OnRecorderError?.Invoke(ex);
                }
            };
            preview.Canceled += (processor) => {
                Console.WriteLine("processing canceled, retaking video");
                OnVideoRecordingCanceled?.Invoke();
            };
            if (CoverSelectorEnabled)
            {
                preview.NextProcessor = new CoverSelector(item);
            }
            ShowViewController(preview, this);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            if (CaptureSession.SetupResult == CaptureSession.SessionSetupResult.Success)
            {
                CaptureSession.Start();
            }

		}

        public override void ViewDidDisappear(bool animated)
        {
			CleanUp();
			CaptureSession?.Stop();

			base.ViewDidDisappear(animated);
        }

        public override void ViewWillTransitionToSize(CoreGraphics.CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        {
            base.ViewWillTransitionToSize(toSize, coordinator);
            CaptureSession?.UpdateOrientation(UIDevice.CurrentDevice.Orientation);
        }

        void Alert(string title, string message, IEnumerable<UIAlertAction> actions = null, UIAlertControllerStyle style = UIAlertControllerStyle.Alert)
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                UIAlertController alert = UIAlertController.Create(title, message, style);
                if (actions != null) foreach (var action in actions) alert.AddAction(action);
                else alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
                PresentViewController(alert, true, null);
            });
        }

        void UpdateUIChangingStateNow()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                cancelButton.Enabled = false;
                recordButton.Enabled = false;
                cameraButton.Enabled = false;
            });
        }

		void UpdateUIInitializedOK()
		{
			DispatchQueue.MainQueue.DispatchAsync(() =>
			{
				cancelButton.Enabled = true;
				recordButton.Enabled = true;
                cameraButton.Enabled = CameraFlipButtonVisible;
			});
		}

        void UpdateUIFailedState()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
				cancelButton.Enabled = true;
                recordButton.Enabled = false;
                cameraButton.Enabled = false;
			});
        }

        void UpdateUIRecordingNow()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                cancelButton.Enabled = true;
                recordButton.Enabled = true;
                cameraButton.Enabled = false;
                recordButton.ImageView.Image = ImageLoader.GetImageFromResource("Stop-100");
            });
	    }

        void UpdateUIRecordingStopped()
        {
			DispatchQueue.MainQueue.DispatchAsync(() =>
			{
				cancelButton.Enabled = true;
				recordButton.Enabled = true;
                cameraButton.Enabled = CameraFlipButtonVisible;
				recordButton.ImageView.Image = ImageLoader.GetImageFromResource("Record-100");
			});
	    }


        public void CancelAndClose()
        {
            OnVideoRecordingCanceled?.Invoke();
            this.DismissViewController(true, null);
		}

        public void SwitchCamera()
        {
            try
            {
                UpdateUIChangingStateNow();

                CaptureSession?.ChangeCamera();

                UpdateUIInitializedOK();
            }
            catch(Exception ex)
            {
                Alert("error", ex.Message);
                UpdateUIFailedState();
                OnRecorderError?.Invoke(ex);
            }
        }

        public bool RecordingNow
        {
            get
            {
                return CaptureSession != null && CaptureSession.RecordingNow;
            }
        }

        private string RawFileName
        {
            get;
            set;
        }

        public Dictionary<string, string> AdditionalParameters 
        { 
            get;
            set; 
        }

        public bool CameraFlipButtonVisible 
        { 
            get;
            set;
        }

        public ZiggeoVideoDevice VideoDevice 
        { 
            get;
            set;
        }

        public double MaxRecordingDurationSeconds 
        { 
            get;
            set;
        }

        private void CleanUp()
        {
            if(BackgroundRecordingID != UIApplication.BackgroundTaskInvalid)
            {
                UIApplication.SharedApplication.EndBackgroundTask(BackgroundRecordingID);
            }
            if (!string.IsNullOrEmpty(RawFileName) && System.IO.File.Exists(RawFileName)) 
            {
                NSError error;
                NSFileManager.DefaultManager.Remove(RawFileName, out error);
                RawFileName = string.Empty;
            }
        }

        private void StartRecording()
        {
            try
            {
                CleanUp();
				if (UIDevice.CurrentDevice.IsMultitaskingSupported)
				{
					BackgroundRecordingID = UIApplication.SharedApplication.BeginBackgroundTask(null);
				}
				UpdateUIChangingStateNow();
				CaptureSession.StartRecording();
                UpdateUIRecordingNow();
            }
            catch(Exception ex)
            {
                Alert("error", ex.Message);
                UpdateUIFailedState();
            }
        }

        private void StopRecording()
        {
			try
			{
                UpdateUIChangingStateNow();
                CaptureSession.StopRecording();
                UpdateUIRecordingStopped();
            }
			catch (Exception ex)
			{
				Alert("error", ex.Message);
				UpdateUIFailedState();
			}
        }

        public void ToggleRecording()
        {
            if (RecordingNow)
            {
                StopRecording();
            }
            else StartRecording();
        }

        public override bool ShouldAutorotate()
        {
            return !RecordingNow;
        }

		public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            CancelAndClose();
        }

        partial void RecordButton_TouchUpInside(UIButton sender)
        {
            ToggleRecording();
        }

        partial void CameraButton_TouchUpInside(UIButton sender)
        {
            SwitchCamera();
        }

        public Task<string> Record()
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            try
            {
                OnRecorderError += (Exception ex) => tcs.TrySetException(ex);
                OnVideoRecordingCanceled += () => tcs.TrySetResult(null);
                OnVideoUploadComplete += (string token) => tcs.TrySetResult(token);
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(this, true, null);
            }
            catch(Exception ex)
            {
                tcs.TrySetException(ex);
            }
            return tcs.Task;
        }
    }
}

