using Android.App;

namespace Ziggeo
{
    public static class UploaderConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Net.Uploading.UploadingConfig Map(UploaderConfig config)
        {
            Com.Ziggeo.Androidsdk.Net.Uploading.UploadingConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.Net.Uploading.UploadingConfig.Builder()
                    .Callback(new UploaderCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}