using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Android.App;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Recording;
using Com.Ziggeo.Androidsdk.UI.Activities;
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
                        var jobj = JObject.Parse(response.Body().String());
                        var token = jobj["video"]["token"].ToString();
                        tcs.TrySetResult(token);
                    }
                    else
                    {
                        tcs.TrySetException(new Exception(response.Message()));
                    }
                }, (call, exception) => { tcs.TrySetException(exception); }));

                var callback = new ActivityLifecycleCallbacks
                {
                    OnStopped = activity =>
                    {
                        if (activity is FullscreenRecorderActivity && activity.IsFinishing)
                        {
                            tcs.TrySetResult(null);
                        }
                    },
                };
                ((Application) Application.Context.ApplicationContext).RegisterActivityLifecycleCallbacks(callback);

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