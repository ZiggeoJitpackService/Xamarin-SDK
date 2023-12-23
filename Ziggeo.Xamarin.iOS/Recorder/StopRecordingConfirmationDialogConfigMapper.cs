namespace Ziggeo
{
    public static class StopRecordingConfirmationDialogConfigMapper
    {
        public static ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig Map(StopRecordingConfirmationDialogConfig config)
        {
            ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig nativeConfig = new ZiggeoMediaSDK.StopRecordingConfirmationDialogConfig();
            if (config != null)
            {
                if (config.titleText != null)
                    nativeConfig.TitleText = config.titleText;
                if (config.mesText != null)
                    nativeConfig.MesText = config.mesText;
                if (config.posBtnText != null)
                    nativeConfig.PosBtnText = config.posBtnText;
                if (config.negBtnText != null)
                    nativeConfig.NegBtnText = config.negBtnText;
            }

            return nativeConfig;
        }
    }
}