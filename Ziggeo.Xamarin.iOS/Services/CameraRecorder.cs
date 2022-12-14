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
    public partial class CameraRecorder : UIViewController
    {
        public CameraRecorder(IZiggeoApplication ziggeoApplication) : base("Recorder", null)
        {
            this.BackgroundRecordingID = UIApplication.BackgroundTaskInvalid;
            this.ZiggeoApplication = ziggeoApplication;
            ShowLightIndicator = true;
            ShowFaceOutline = true;
            ShowAudioIndicator = true;
        }

        private CaptureSession CaptureSession { get; set; }

        public nint BackgroundRecordingID { get; private set; }

        public IZiggeoApplication ZiggeoApplication { get; private set; }

        private UITapGestureRecognizer FocusTapGesture { get; set; }

        public bool CoverSelectorEnabled { get; set; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            faceOutlineView.Hidden = !ShowFaceOutline;
            audioLevelView.Hidden = !ShowAudioIndicator;
            luxMeter.Hidden = !ShowLightIndicator;

            // Perform any additional setup after loading the view, typically from a nib.
            PreviewView.UserInteractionEnabled = true;
            FocusTapGesture = new UITapGestureRecognizer(() =>
            {
                if (CaptureSession != null)
                {
                    CoreGraphics.CGPoint devicePoint =
                        (PreviewView.Layer as AVFoundation.AVCaptureVideoPreviewLayer)
                        .CaptureDevicePointOfInterestForPoint(FocusTapGesture.LocationInView(FocusTapGesture.View));
                    CaptureSession.Focus(AVFoundation.AVCaptureFocusMode.AutoFocus,
                        AVFoundation.AVCaptureExposureMode.AutoExpose, devicePoint, true);
                }
            });
            PreviewView.AddGestureRecognizer(FocusTapGesture);

            UpdateUIChangingStateNow();
            try
            {
                CaptureSession = new CaptureSession(PreviewView);
                CaptureSession.MaxDuration = MaxRecordingDurationSeconds;
                // CaptureSession.Quality = VideoQuality;
                // CaptureSession.CaptureDevicePosition = (VideoDevice == Ziggeo.VideoDevice.Front
                    // ? AVCaptureDevicePosition.Front
                    // : AVCaptureDevicePosition.Back);
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
                    UIAlertAction settings = UIAlertAction.Create("Settings", UIAlertActionStyle.Default,
                        (obj) =>
                        {
                            UIApplication.SharedApplication.OpenUrl(new NSUrl(UIApplication.OpenSettingsUrlString));
                        });
                    UpdateUIFailedState();
                    Alert("error",
                        "The application doesn't have permission to use the camera, please change privacy settings",
                        new[] {cancel, settings});
                };
                CaptureSession.RuntimeError += (session, error) =>
                {
                    UpdateUIFailedState();
                    Alert("error", error.Domain);
                    ZiggeoApplication.CameraRecorderConfig.InvokeError(new Exception(error.Description));
                };
                CaptureSession.RecordingFinished += (session, outputFile) =>
                {
                    Console.WriteLine("recording finished: " + outputFile);
                    UpdateUIRecordingStopped();
                    DispatchQueue.MainQueue.DispatchAsync(() => { StartVideoProcessorChain(outputFile); });
                };
                CaptureSession.RunningStateChanged += (session) =>
                {
                    Console.WriteLine("running state changed: " + session.Running);
                };
                CaptureSession.SubjectAreaDidChange += (session) =>
                {
                    Console.WriteLine("subject area did change");
                    CaptureSession?.Focus(AVFoundation.AVCaptureFocusMode.ContinuousAutoFocus,
                        AVFoundation.AVCaptureExposureMode.ContinuousAutoExposure, new CoreGraphics.CGPoint(0.5, 0.5),
                        false);
                };
                CaptureSession.RecordingDurationChanged += (session) =>
                {
                    ZiggeoApplication.CameraRecorderConfig.InvokeRecordingProgress(session.Duration);
                    RenderDuration();
                };
                // CaptureSession.LuminosityUpdated += (session, value) =>
                // {
                // luxMeter.Luminosity = value;
                // DrawFaces();
                // };
                CaptureSession.AudioLevelUpdated += (session, value) =>
                {
                    // ZiggeoApplication.CameraRecorderConfig.InvokeMicrophoneHealth(value);
                    audioLevelView.AudioLevel = value;
                };
                // CaptureSession.FaceDetected += (session, rect, faceID) =>
                // {
                // FaceDetected?.Invoke(faceID, rect.Left, rect.Top, rect.Width, rect.Height);
                // faceOutlineView.AddFace(faceID, rect);
                // };
                CaptureSession.Setup();
            }
            catch (Exception ex)
            {
                UpdateUIFailedState();
                Alert("error", ex.ToString());
                ZiggeoApplication.CameraRecorderConfig.InvokeError(ex);
            }
        }

        private void DrawFaces()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                if (!faceOutlineView.Hidden)
                {
                    faceOutlineView.SetNeedsDisplay();
                }
            });
        }

        protected virtual void StartVideoProcessorChain(NSUrl fileName)
        {
            VideoItem item = new VideoItem(fileName);
            VideoProcessor preview = new PreviewAndUpload(item);
            preview.Done += async (processor) =>
            {
                try
                {
                    DismissViewController(true, null);
                    Console.WriteLine("processing done, file: {0}, cover: {1}", item.FilePath, item.Cover != null);

                    VideoConverter converter = new VideoConverter(item.FilePath.Path);
                    Console.WriteLine("converting started");
                    NSString preset;
                    // switch (VideoQuality)
                    // {
                    // case VideoQuality.High:
                    preset = AVAssetExportSessionPreset.HighestQuality.GetConstant();
                    // break;
                    // case VideoQuality.Low:
                    // preset = AVAssetExportSessionPreset.LowQuality.GetConstant();
                    // break;
                    // default:
                    // preset = AVAssetExportSessionPreset.MediumQuality.GetConstant();
                    // break;
                    // }

                    string convertedVideo = await converter.Convert(preset);
                    Console.WriteLine("converting complete");

                    Console.WriteLine("uploading...");
                    var video = await ZiggeoApplication.Videos.Create(convertedVideo, AdditionalParameters);
                    string videoToken = video["video"]["token"].Value<string>();
                    Console.WriteLine("uploading done: {0}", videoToken);
                    // RecordingFinishedUploadDone?.Invoke(videoToken);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    // RecordingError?.Invoke(ex);
                }
            };
            preview.Canceled += (processor) =>
            {
                Console.WriteLine("processing canceled, retaking video");
                //RecordingCanceled?.Invoke();
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

        public override void ViewWillTransitionToSize(CoreGraphics.CGSize toSize,
            IUIViewControllerTransitionCoordinator coordinator)
        {
            base.ViewWillTransitionToSize(toSize, coordinator);
            CaptureSession?.UpdateOrientation(UIDevice.CurrentDevice.Orientation);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            CaptureSession?.UpdateOrientation(UIDevice.CurrentDevice.Orientation);
        }

        void Alert(string title, string message, IEnumerable<UIAlertAction> actions = null,
            UIAlertControllerStyle style = UIAlertControllerStyle.Alert)
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                UIAlertController alert = UIAlertController.Create(title, message, style);
                if (actions != null)
                    foreach (var action in actions)
                        alert.AddAction(action);
                else alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
                PresentViewController(alert, true, null);
            });
        }

        void RenderDuration()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                double duration = CaptureSession != null ? CaptureSession.Duration : 0;
                if (MaxRecordingDurationSeconds > 0)
                {
                    double remainingDuration = MaxRecordingDurationSeconds - duration;
                    if (remainingDuration < 0) remainingDuration = 0;
                    duration = remainingDuration;
                }

                int minutes = (int) (duration / 60);
                int seconds = ((int) (duration + 0.4)) % 60;
                string currentDurationSeconds = string.Format("{0:00}:{1:00}", minutes, seconds);
                durationLabel.Text = currentDurationSeconds;
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
            RenderDuration();
        }

        void UpdateUIInitializedOK()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                cancelButton.Enabled = true;
                recordButton.Enabled = true;
                cameraButton.Enabled = CameraFlipButtonVisible;
            });
            RenderDuration();
        }

        void UpdateUIFailedState()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                cancelButton.Enabled = true;
                recordButton.Enabled = false;
                cameraButton.Enabled = false;
            });
            RenderDuration();
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
            RenderDuration();
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
            RenderDuration();
        }


        public void CancelAndClose()
        {
            this.DismissViewController(true, null);
            // RecordingCanceled?.Invoke();
        }

        public void SwitchCamera()
        {
            try
            {
                UpdateUIChangingStateNow();

                CaptureSession?.ChangeCamera();

                UpdateUIInitializedOK();
            }
            catch (Exception ex)
            {
                Alert("error", ex.Message);
                UpdateUIFailedState();
                // RecordingError?.Invoke(ex);
            }
        }

        public bool RecordingNow
        {
            get { return CaptureSession != null && CaptureSession.RecordingNow; }
        }

        private string RawFileName { get; set; }

        public Dictionary<string, string> AdditionalParameters { get; set; }

        public bool CameraFlipButtonVisible { get; set; }

        public double MaxRecordingDurationSeconds { get; set; }

        public bool ShowLightIndicator { get; set; }
        public bool ShowAudioIndicator { get; set; }
        public bool ShowFaceOutline { get; set; }

        private void CleanUp()
        {
            if (BackgroundRecordingID != UIApplication.BackgroundTaskInvalid)
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
                // RecordingStarted?.Invoke();
                CleanUp();
                if (UIDevice.CurrentDevice.IsMultitaskingSupported)
                {
                    BackgroundRecordingID = UIApplication.SharedApplication.BeginBackgroundTask(null);
                }

                UpdateUIChangingStateNow();
                CaptureSession.StartRecording();
                UpdateUIRecordingNow();
            }
            catch (Exception ex)
            {
                Alert("error", ex.Message);
                UpdateUIFailedState();
            }
        }

        private void StopRecording()
        {
            try
            {
                // RecordingStopped?.Invoke();
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

        public void StartRecorder()
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            try
            {
                // RecordingError += (Exception ex) => tcs.TrySetException(ex);
                // RecordingCanceled += () => tcs.TrySetResult(null);
                // RecordingFinishedUploadDone += (string token) => tcs.TrySetResult(token);
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(this, true, null);
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }
        }
    }
}