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
        public Action<Throwable> OnError;
        public Action OnLoaded;
        public Action OnCanceledByUser;
        public Action OnAccessGranted;
        public Action<IList<string>> OnAccessForbidden;
        public Action OnNoMicrophone;
        public Action OnHasMicrophone;
        public Action OnHasCamera;
        public Action OnNoCamera;
        public Action<int> OnMicrophoneHealth;
        public Action<string> OnDecoded;

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            OnAccessForbidden?.Invoke(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            OnAccessGranted?.Invoke();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            OnCanceledByUser?.Invoke();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            OnError?.Invoke(throwable);
        }

        public override void HasCamera()
        {
            base.HasCamera();
            OnHasCamera?.Invoke();
        }

        public override void HasMicrophone()
        {
            base.HasMicrophone();
            OnHasMicrophone?.Invoke();
        }

        public override void Loaded()
        {
            base.Loaded();
            OnLoaded?.Invoke();
        }

        public override void NoCamera()
        {
            base.NoCamera();
            OnNoCamera?.Invoke();
        }

        public override void NoMicrophone()
        {
            base.NoMicrophone();
            OnNoMicrophone?.Invoke();
        }

        public override void OnQrDecoded(string value)
        {
            base.OnQrDecoded(value);
            OnDecoded?.Invoke(value);
        }
    }
}