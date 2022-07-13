using Android.App;

namespace Ziggeo
{
    public static class ScreenRecorderConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.Recorder.RecorderConfig Map(ScreenRecorderConfig config)
        {
            Com.Ziggeo.Androidsdk.Recorder.RecorderConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.Recorder.RecorderConfig.Builder(Application.Context)
                    .Callback(new RecorderCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}