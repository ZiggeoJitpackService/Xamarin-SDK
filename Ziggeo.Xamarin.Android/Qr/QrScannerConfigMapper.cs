namespace Ziggeo
{
    public static class QrScannerConfigMapper
    {
        public static Com.Ziggeo.Androidsdk.QR.QrScannerConfig Map(QrScannerConfig config)
        {
            Com.Ziggeo.Androidsdk.QR.QrScannerConfig nativeConfig = null;
            if (config != null)
            {
                nativeConfig = new Com.Ziggeo.Androidsdk.QR.QrScannerConfig.Builder()
                    .ShouldCloseAfterSuccessfulScan(config.ShouldCloseAfterSuccessfulScan)
                    .Callback(new QrScannerCallback(config))
                    .Build();
            }

            return nativeConfig;
        }
    }
}