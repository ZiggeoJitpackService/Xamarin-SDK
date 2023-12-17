namespace Ziggeo
{
    public static class PlayerConfigMapper
    {
        public static ZiggeoMediaSDK.PlayerConfig Map(PlayerConfig config)
        {
            ZiggeoMediaSDK.PlayerConfig nativeConfig = new ZiggeoMediaSDK.PlayerConfig();
            ZiggeoMediaSDK.PlayerStyle nativeStyle = new ZiggeoMediaSDK.PlayerStyle();

            if (config != null)
            {
                if (config.PlayerStyle != null)
                {
                    nativeStyle.HideControls = false;
                }

                nativeConfig.ShouldShowSubtitles = config.ShouldShowSubtitles;
                nativeConfig.IsMuted = config.IsMuted;
            }

            return nativeConfig;
        }
    }
}