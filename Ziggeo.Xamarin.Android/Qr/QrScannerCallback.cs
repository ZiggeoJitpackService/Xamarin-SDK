using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.QR;
using Java.Lang;

namespace Ziggeo
{
    public class QrScannerCallback : Com.Ziggeo.Androidsdk.QR.QrScannerCallback
    {
        public QrScannerConfig Config { get; set; }

        public QrScannerCallback(QrScannerConfig config)
        {
            Config = config;
        }

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            Config.InvokeAccessForbidden(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            Config.InvokeAccessGranted();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            Config.InvokeCancelledByUser();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Config.InvokeError(throwable);
        }

        public override void HasCamera()
        {
            base.HasCamera();
            Config.InvokeHasCamera();
        }

        public override void HasMicrophone()
        {
            base.HasMicrophone();
            Config.InvokeHasMicrophone();
        }

        public override void Loaded()
        {
            base.Loaded();
            Config.InvokeLoaded();
        }

        public override void NoCamera()
        {
            base.NoCamera();
            Config.InvokeNoCamera();
        }

        public override void NoMicrophone()
        {
            base.NoMicrophone();
            Config.InvokeNoMicrophone();
        }

        public override void OnQrDecoded(string value)
        {
            base.OnQrDecoded(value);
            Config.InvokeDecoded(value);
        }
    }
}