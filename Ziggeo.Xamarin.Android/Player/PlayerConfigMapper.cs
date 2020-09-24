using Android.App;

namespace Ziggeo
{
    public static class PlayerConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Player.PlayerConfig Map(PlayerConfig config)
        {
            Com.Ziggeo.Androidsdk.Player.PlayerConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.Player.PlayerConfig.Builder(Application.Context)
                    .Callback(new PlayerCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}