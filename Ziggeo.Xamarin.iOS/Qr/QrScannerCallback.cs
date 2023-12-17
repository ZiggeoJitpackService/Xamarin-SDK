using System;
using System.Collections.Generic;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class QrScannerCallback : ZiggeoQRScannerDelegate
    {
        public QrScannerConfig Config { get; set; }

        public QrScannerCallback(QrScannerConfig config)
        {
            Config = config;
        }

        public override void QrCodeScaned(string qrCode)
        {
            Config.InvokeDecoded(qrCode);
        }

        public override void QrCodeScanCancelledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        // Common
        public void AccessForbidden(IList<string> permissions)
        {
            Config.InvokeAccessForbidden(permissions);
        }

        public void AccessGranted()
        {
            Config.InvokeAccessGranted();
        }

        public void CanceledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        public void Error(Exception throwable)
        {
            Config.InvokeError(throwable);
        }

        public void Loaded()
        {
            Config.InvokeLoaded();
        }
    }
}