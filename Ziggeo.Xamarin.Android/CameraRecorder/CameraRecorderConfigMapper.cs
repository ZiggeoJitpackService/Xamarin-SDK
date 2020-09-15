using Android.App;

namespace Ziggeo
{
    public static class CameraRecorderConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Recorder.RecorderConfig map(CameraRecorderConfig config)
        {
            Com.Ziggeo.Androidsdk.Recorder.RecorderConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.Recorder.RecorderConfig.Builder(Application.Context)
                    .ShouldShowFaceOutline(config.ShouldShowFaceOutline)
                    .IsLiveStreaming(config.IsLiveStreaming)
                    .ShouldAutoStartRecording(config.ShouldAutoStartRecording)
                    .StartDelay(config.StartDelay)
                    .ShouldSendImmediately(config.ShouldSendImmediately)
                    .ShouldDisableCameraSwitch(config.ShouldDisableCameraSwitch)
                    .Quality(config.VideoQuality)
                    .Facing(config.Facing)
                    .MaxDuration(config.MaxDuration)
                    .ShouldEnableCoverShot(config.ShouldEnableCoverShot)
                    .ShouldConfirmStopRecording(config.ShouldConfirmStopRecording)
                    .Callback(new CameraRecorderCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}