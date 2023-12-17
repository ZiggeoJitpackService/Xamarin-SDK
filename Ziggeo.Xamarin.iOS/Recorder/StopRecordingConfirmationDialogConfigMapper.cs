namespace Ziggeo
{
    public static class StopRecordingConfirmationDialogConfigMapper
    {
        public static ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig Map(StopRecordingConfirmationDialogConfig config)
        {
            ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig nativeConfig = new ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig();
            if (config != null)
            {
                nativeConfig.TitleText = config.titleText;
                nativeConfig.MesText = config.mesText;
                nativeConfig.PosBtnText = config.posBtnText;
                nativeConfig.NegBtnText = config.negBtnText;
            }

            return nativeConfig;
        }
    }
}