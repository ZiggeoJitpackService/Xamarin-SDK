using Android.App;

namespace Ziggeo
{
    public static class FileSelectorConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Fileselector.FileSelectorConfig Map(FileSelectorConfig config)
        {
            Com.Ziggeo.Androidsdk.Fileselector.FileSelectorConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.Fileselector.FileSelectorConfig.Builder(Application.Context)
                    .Callback(new FileSelectorCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}