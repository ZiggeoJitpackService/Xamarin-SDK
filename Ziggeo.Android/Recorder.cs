﻿using System;
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
        public event RecorderDelegate RecordingStarted;
        public event RecorderDelegate RecordingCanceled;
        public event RecordingFinishedDelegate RecordingFinishedUploadDone;
        public event RecorderErrorDelegate RecordingError;

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

        public VideoQuality VideoQuality { get; set; }

        public double MaxRecordingDurationSeconds { get; set; }

        public Task<string> Record()
        {
            RecordingStarted?.Invoke();
            var tcs = new TaskCompletionSource<string>();
            var isRecording = false;
            try
            {
                Ziggeo.CoverSelectorEnabled = CoverSelectorEnabled;
                Ziggeo.ExtraArgsForRecorder = AdditionalParameters;
                Ziggeo.SetCameraSwitchDisabled(!CameraFlipButtonVisible);
                Ziggeo.SetPreferredCameraFacing((int) VideoDevice);
                Ziggeo.PreferredQuality = (int) VideoQuality;
                Ziggeo.SetMaxRecordingDuration((long) (MaxRecordingDurationSeconds * 1000));
                Ziggeo.VideoRecordingProcessCallback = new RecorderCallback(throwable =>
                {
                    tcs.TrySetException(throwable);
                    RecordingError?.Invoke(throwable);
                }, () => isRecording = true, null, null);

                Ziggeo.SetNetworkRequestsCallback(new ProgressCallback((call, response) =>
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
                            RecordingError?.Invoke(ex);
                        }
                    }, (call, exception) =>
                    {
                        tcs.TrySetException(exception);
                        RecordingError?.Invoke(exception);
                    }, (token, file, sent, total) => { }
                ));

                // return null when a user manually close the recorder screen
                var callback = new ActivityLifecycleCallbacks
                {
                    OnStopped = activity =>
                    {
                        if (activity is CameraRecorderActivity && activity.IsFinishing && !isRecording)
                        {
                            tcs.TrySetResult(null);
                            RecordingCanceled?.Invoke();
                        }
                    }
                };
                ((Application) Application.Context.ApplicationContext).RegisterActivityLifecycleCallbacks(callback);

                Ziggeo.StartRecorder();
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