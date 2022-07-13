using Android.App;

namespace Ziggeo
{
    public static class PlayerConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Player.PlayerConfig Map(PlayerConfig config)
        {
            Com.Ziggeo.Androidsdk.Player.PlayerConfig nativeConfig = null;
            Com.Ziggeo.Androidsdk.UI.Theming.PlayerStyle nativeStyle = null;


            if (config != null)
            {
                if (config.PlayerStyle != null)
                {
                    nativeStyle = new Com.Ziggeo.Androidsdk.UI.Theming.PlayerStyle.Builder()
                    .BufferedColor(config.PlayerStyle.BufferedColor)
                    .ControllerStyle(config.PlayerStyle.ControllerStyle)
                    .PlayedColor(config.PlayerStyle.PlayedColor)
                    .TextColor(config.PlayerStyle.TextColor)
                    .TintColor(config.PlayerStyle.TintColor)
                    .UnplayedColor(config.PlayerStyle.UnplayedColor)
                    .MuteOffImageDrawable(config.PlayerStyle.MuteOffImageDrawable)
                    .MuteOnImageDrawable(config.PlayerStyle.MuteOnImageDrawable)
                    .Build();
                }

                nativeConfig = new Com.Ziggeo.Androidsdk.Player.PlayerConfig.Builder(Application.Context)
                    .Callback(new PlayerCallback(config))
                    .IsMuted(config.IsMuted)
                    .ShowSubtitles(config.ShouldShowSubtitles)
                    .Style(nativeStyle)
                    .Build();
            }

            return nativeConfig;
        }
    }
}