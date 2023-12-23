namespace Ziggeo
{
    public static class CameraRecorderConfigMapper
    {
        public static ZiggeoMediaSDK.RecorderConfig Map(CameraRecorderConfig config)
        {
            ZiggeoMediaSDK.RecorderConfig nativeConfig = new ZiggeoMediaSDK.RecorderConfig();
            if (config != null)
            {
                nativeConfig.ShouldShowFaceOutline = config.ShouldShowFaceOutline;
                nativeConfig.IsLiveStreaming = config.IsLiveStreaming;
                nativeConfig.ShouldAutoStartRecording = config.ShouldAutoStartRecording;
                nativeConfig.StartDelay = config.StartDelay;
                nativeConfig.BlurMode = config.BlurMode;
                nativeConfig.ShouldSendImmediately = config.ShouldSendImmediately;
                nativeConfig.ShouldDisableCameraSwitch = config.ShouldDisableCameraSwitch;
                nativeConfig.VideoQuality = config.VideoQuality;
                nativeConfig.Facing = config.Facing;
                nativeConfig.MaxDuration = (int)config.MaxDuration;
                nativeConfig.ShouldEnableCoverShot = config.ShouldEnableCoverShot;
                nativeConfig.ShouldConfirmStopRecording = config.ShouldConfirmStopRecording;
                if (config.StopRecordingConfirmationDialogConfig != null)
                    nativeConfig.StopRecordingConfirmationDialogConfig = StopRecordingConfirmationDialogConfigMapper.Map(config.StopRecordingConfirmationDialogConfig);
                nativeConfig.IsPausedMode = config.PausedMode;
            }

            return nativeConfig;
        }
    }
}