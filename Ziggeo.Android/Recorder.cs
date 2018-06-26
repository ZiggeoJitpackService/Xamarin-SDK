using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Recording;
using Newtonsoft.Json.Linq;
using Ziggeo.Services;


namespace Ziggeo

{
    public partial class Recorder : IZiggeoRecorder
    {
        public Recorder(IZiggeoApplication ziggeoApplication)
        {
            this.ZiggeoApplication = ziggeoApplication;
            this.Ziggeo = ((ZiggeoApplication) ZiggeoApplication).Ziggeo;
        }

        private IZiggeo Ziggeo;

        public IZiggeoApplication ZiggeoApplication { get; private set; }

        public bool CoverSelectorEnabled { get; set; }

        public Dictionary<string, string> AdditionalParameters { get; set; }

        public bool CameraFlipButtonVisible { get; set; }

        public ZiggeoVideoDevice VideoDevice { get; set; }

        public VideoQuality VideQuality { get; set; }

        public double MaxRecordingDurationSeconds { get; set; }

        public Task<string> Record()
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();

            try
            {
                OnVideoRecordingCanceled += () => tcs.TrySetResult(null);

                Ziggeo.SetCoverSelectorEnabled(CoverSelectorEnabled);
                Ziggeo.SetExtraArgsForRecorder(AdditionalParameters);
                Ziggeo.SetCameraSwitchDisabled(!CameraFlipButtonVisible);
                Ziggeo.SetPreferredCameraFacing((int) VideoDevice);
                Ziggeo.SetPreferredQuality((int) VideQuality);
                Ziggeo.SetMaxRecordingDuration((long) (MaxRecordingDurationSeconds * 1000));
                Ziggeo.VideoRecordingProcessCallback =
                    new RecorderCallback(throwable => tcs.TrySetException(throwable), null, null, null);
                Ziggeo.SetNetworkRequestsCallback(new Callback((call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        var token = new JObject(response.Body().String()).GetValue("token").ToString();
                        tcs.TrySetResult(token);
                    }
                    else
                    {
                        tcs.TrySetException(new Exception(response.Message()));
                    }
                }, (call, exception) => { tcs.TrySetException(exception); }));
                var callback = new ActivityLifecycleCallbacks();
                callback.OnStopped = activity => { activity.IsFinishing };
                Android.App.Application.Context.RegisterComponentCallbacks(new ActivityLifecycleCallbacks());
                Ziggeo.StartRecorder();
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }

            return tcs.Task;
        }
    }
}