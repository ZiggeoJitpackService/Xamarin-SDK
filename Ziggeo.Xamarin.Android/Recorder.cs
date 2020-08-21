using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Recorder;
using Com.Ziggeo.Androidsdk.UI.Activities;

namespace Ziggeo
{
    public partial class Recorder : IZiggeoRecorder
    {
        public event RecorderDelegate RecordingStarted;
        public event RecorderDelegate RecordingStopped;
        public event RecorderDelegate RecordingCanceled;
        public event RecordingFinishedDelegate RecordingFinishedUploadDone;
        public event RecorderErrorDelegate RecordingError;
        public event RecordingDurationDelegate RecordingDurationUpdated;
        public event LuxMeterDelegate LuminosityUpdated;
        public event AudioMeterDelegate AudioLevelUpdated;
        public event FaceDetectorDelegate FaceDetected;

        public Recorder(IZiggeoApplication ziggeoApplication)
        {
            this.ZiggeoApplication = ziggeoApplication;
            this._ziggeo = ((ZiggeoApplication) ZiggeoApplication).Ziggeo;
        }

        private readonly IZiggeo _ziggeo;
        private bool _isRecordingStarted;
        private ActivityLifecycleCallbacks _callbacks;

        public IZiggeoApplication ZiggeoApplication { get; private set; }

        public bool CoverSelectorEnabled { get; set; }

        public Dictionary<string, string> AdditionalParameters { get; set; }

        public bool CameraFlipButtonVisible { get; set; }

        public ZiggeoVideoDevice VideoDevice { get; set; }

        public VideoQuality VideoQuality { get; set; }

        public double MaxRecordingDurationSeconds { get; set; }
        public bool ShowLightIndicator { get; set; }
        public bool ShowAudioIndicator { get; set; }
        public bool ShowFaceOutline { get; set; }

        public Task<string> Record()
        {
            var tcs = new TaskCompletionSource<string>();
            _isRecordingStarted = false;
            try
            {
                RecorderCallback recorderCallback = new RecorderCallback
                {
                    _onError = throwable =>
                    {
                        tcs.TrySetException(throwable);
                        RecordingError?.Invoke(throwable);
                    },
                    _onRecordingStarted = () =>
                    {
                        _isRecordingStarted = true;
                        RecordingStarted?.Invoke();
                    },
                    _onRecordingStopped = path => { RecordingStopped?.Invoke(); },
                    _onUploadingFinished = (path, token) =>
                    {
                        tcs.TrySetResult(token);
                        RecordingFinishedUploadDone?.Invoke(token);
                    }
                };
                _ziggeo.RecorderConfig = new RecorderConfig.Builder(Application.Context)
                    .ShouldDisableCameraSwitch(!CameraFlipButtonVisible)
                    .Facing((int) VideoDevice)
                    .ExtraArgs(AdditionalParameters)
                    .ShouldEnableCoverShot(CoverSelectorEnabled)
                    .Quality((int) VideoQuality)
                    .MaxDuration((long) (MaxRecordingDurationSeconds * 1000))
                    .Callback(recorderCallback)
                    .Build();

                // return null when a user manually close the recorder screen
                if (_callbacks == null)
                {
                    _callbacks = new ActivityLifecycleCallbacks
                    {
                        OnStopped = activity =>
                        {
                            if (activity is CameraRecorderActivity && activity.IsFinishing && !_isRecordingStarted)
                            {
                                tcs.TrySetResult(null);
                                RecordingCanceled?.Invoke();
                            }
                        }
                    };
                    ((Application) Application.Context.ApplicationContext)?.RegisterActivityLifecycleCallbacks(
                        _callbacks);
                }

                _ziggeo.StartCameraRecorder();
            }
            catch (Exception ex)
            {
                RecordingError?.Invoke(ex);
                tcs.TrySetException(ex);
            }

            return tcs.Task;
        }
    }
}