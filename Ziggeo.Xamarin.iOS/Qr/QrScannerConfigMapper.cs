namespace Ziggeo
{
    public static class QrScannerConfigMapper
    {
        public static ZiggeoMediaSDK.QrScannerConfig Map(QrScannerConfig config)
        {
            ZiggeoMediaSDK.QrScannerConfig nativeConfig = new ZiggeoMediaSDK.QrScannerConfig();
            if (config != null)
            {
                nativeConfig.ShouldCloseAfterSuccessfulScan = config.ShouldCloseAfterSuccessfulScan;
            }

            return nativeConfig;
        }
    }
}