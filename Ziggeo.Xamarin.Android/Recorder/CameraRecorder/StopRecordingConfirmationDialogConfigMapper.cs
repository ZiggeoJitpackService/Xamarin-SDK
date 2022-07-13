using Android.App;

namespace Ziggeo
{
    public static class StopRecordingConfirmationDialogConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig Map(
            StopRecordingConfirmationDialogConfig config)
        {
            Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig =
                    new Com.Ziggeo.Androidsdk.StopRecordingConfirmationDialogConfig.Builder()
                        .TitleResId(config.titleResId)
                        .TitleText(config.titleText)
                        .MesResId(config.mesResId)
                        .MesText(config.mesText)
                        .PosBtnResId(config.posBtnResId)
                        .PosBtnText(config.posBtnText)
                        .NegBtnResId(config.negBtnResId)
                        .NegBtnText(config.negBtnText)
                        .Build();
            }

            return nativeConfig;
        }
    }
}