using System;
using System.Collections.Generic;

namespace Ziggeo
{
    public class QrScannerConfig : BaseConfig, IQrScannerEventsListener
    {
        public bool ShouldCloseAfterSuccessfulScan = true;
        public event ErrorDelegate Error;
        public event LoadedDelegate Loaded;
        public event CanceledByUserDelegate CanceledByUser;
        public event AccessGrantedDelegate AccessGranted;
        public event AccessForbiddenDelegate AccessForbidden;
        public event NoMicrophoneDelegate NoMicrophone;
        public event HasMicrophoneDelegate HasMicrophone;
        public event HasCameraDelegate HasCamera;
        public event NoCameraDelegate NoCamera;
        public event MicrophoneHealthDelegate MicrophoneHealth;
        public event DecodedDelegate Decoded;

        public void InvokeError(Exception e)
        {
            Error?.Invoke(e);
        }

        public void InvokeLoaded()
        {
            Loaded?.Invoke();
        }

        public void InvokeCancelledByUser()
        {
            CanceledByUser?.Invoke();
        }

        public void InvokeAccessGranted()
        {
            AccessGranted?.Invoke();
        }

        public void InvokeAccessForbidden(IList<string> permissions)
        {
            AccessForbidden?.Invoke(permissions);
        }

        public void InvokeNoMicrophone()
        {
            NoMicrophone?.Invoke();
        }

        public void InvokeHasMicrophone()
        {
            HasMicrophone?.Invoke();
        }

        public void InvokeHasCamera()
        {
            HasCamera?.Invoke();
        }

        public void InvokeNoCamera()
        {
            NoCamera?.Invoke();
        }

        public void InvokeMicrophoneHealth(int value)
        {
            MicrophoneHealth?.Invoke(value);
        }

        public void InvokeDecoded(string value)
        {
            Decoded?.Invoke(value);
        }
    }
}