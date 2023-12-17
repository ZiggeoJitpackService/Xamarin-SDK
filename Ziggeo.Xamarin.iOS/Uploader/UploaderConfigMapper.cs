namespace Ziggeo
{
    public static class UploaderConfigMapper
    {
        public static ZiggeoMediaSDK.UploadingConfig Map(UploaderConfig config)
        {
            ZiggeoMediaSDK.UploadingConfig nativeConfig = new ZiggeoMediaSDK.UploadingConfig();
            if (config != null)
            {
                nativeConfig.ShouldTurnOffUploader = config.ShouldTurnOffUploader;
                nativeConfig.LostConnectionAction = config.LostConnectionAction;
                nativeConfig.ShouldUseWifiOnly = config.ShouldUseWifiOnly;
                nativeConfig.ShouldStartAsForeground = config.ShouldStartAsForeground;
            }

            return nativeConfig;
        }
    }
}