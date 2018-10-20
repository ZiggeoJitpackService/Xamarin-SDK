using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.UI.Activities;
using Newtonsoft.Json.Linq;
using Ziggeo.Services;


namespace Ziggeo
{
    public partial class Recorder : IZiggeoRecorder
    {
        public event RecorderDelegate RecordingStarted;
        public event RecorderDelegate RecordingCanceled;
        public event RecordingFinishedDelegate RecordingFinishedUploadDone;
        public event RecorderErrorDelegate RecordingError;

        public Recorder(IZiggeoApplication ziggeoApplication)
        {
            this.ZiggeoApplication = ziggeoApplication;
            this._ziggeo = ((ZiggeoApplication) ZiggeoApplication).Ziggeo;
        }

        private readonly IZiggeo _ziggeo;
        private bool _isRecording;
        private ActivityLifecycleCallbacks _callbacks;

        public IZiggeoApplication ZiggeoApplication { get; private set; }

        public bool CoverSelectorEnabled { get; set; }

        public Dictionary<string, string> AdditionalParameters { get; set; }

        public bool CameraFlipButtonVisible { get; set; }

        public ZiggeoVideoDevice VideoDevice { get; set; }

        public VideoQuality VideoQuality { get; set; }

        public double MaxRecordingDurationSeconds { get; set; }

        public Task<string> Record()
        {
            var tcs = new TaskCompletionSource<string>();
            _isRecording = false;
            try
            {
                _ziggeo.CoverSelectorEnabled = CoverSelectorEnabled;
                _ziggeo.ExtraArgsForRecorder = AdditionalParameters;
                _ziggeo.SetCameraSwitchDisabled(!CameraFlipButtonVisible);
                _ziggeo.SetPreferredCameraFacing((int) VideoDevice);
                _ziggeo.PreferredQuality = (int) VideoQuality;
                _ziggeo.SetMaxRecordingDuration((long) (MaxRecordingDurationSeconds * 1000));
                _ziggeo.VideoRecordingProcessCallback = new RecorderCallback(throwable =>
                {
                    tcs.TrySetException(throwable);
                    RecordingError?.Invoke(throwable);
                }, () =>
                {
                    _isRecording = true;
                    RecordingStarted?.Invoke();
                }, null, null);

                _ziggeo.SetNetworkRequestsCallback(new ProgressCallback((call, response) =>
                    {
                        if (response.IsSuccessful)
                        {
                            var parsedResponse = JObject.Parse(response.Body().String());
                            var token = parsedResponse["token"].Value<string>();
                            tcs.TrySetResult(token);
                            RecordingFinishedUploadDone?.Invoke(token);
                        }
                        else
                        {
                            Exception ex = new Exception(response.Message());
                            tcs.TrySetException(ex);
                        }
                    }, (call, exception) => { tcs.TrySetException(exception); }, (token, file, sent, total) => { }
                ));

                // return null when a user manually close the recorder screen
                if (_callbacks == null)
                {
                    _callbacks = new ActivityLifecycleCallbacks
                    {
                        OnStopped = activity =>
                        {
                            if (activity is CameraRecorderActivity && activity.IsFinishing && !_isRecording)
                            {
                                tcs.TrySetResult(null);
                                RecordingCanceled?.Invoke();
                            }
                        }
                    };
                    ((Application) Application.Context.ApplicationContext).RegisterActivityLifecycleCallbacks(
                        _callbacks);
                }

                _ziggeo.StartRecorder();
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