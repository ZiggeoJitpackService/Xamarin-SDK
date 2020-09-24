namespace Ziggeo
{
    public static class QrScannerConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.QR.QrScannerConfig Map(QrScannerConfig config)
        {
            Com.Ziggeo.Androidsdk.QR.QrScannerConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.QR.QrScannerConfig(config.ShouldCloseAfterSuccessfulScan,
                    new QrScannerCallback(config));
            }

            return nativeConfig;
        }
    }
}