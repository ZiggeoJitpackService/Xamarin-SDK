using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.QR;

namespace Ziggeo
{
    public partial class QrScanner : IZiggeoQrScanner
    {
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

        public bool ShouldCloseAfterSuccessfulScan { get; set; }

        public QrScanner(IZiggeoApplication application)
        {
            this.Application = application;
            this.Ziggeo = ((ZiggeoApplication) Application).Ziggeo;
        }

        private IZiggeo Ziggeo;

        public IZiggeoApplication Application { get; private set; }

        public Task StartQrScanner()
        {
            TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
            try
            {
                Ziggeo.QrScannerConfig = new QrScannerConfig(ShouldCloseAfterSuccessfulScan, new QrScannerCallback
                {
                    OnError = throwable => { Error?.Invoke(throwable); },
                    OnDecoded = qr => { Decoded?.Invoke(qr); },
                    OnLoaded = () => { Loaded?.Invoke(); },
                    OnAccessForbidden = permissions => { AccessForbidden?.Invoke(permissions); },
                    OnAccessGranted = () => { AccessGranted?.Invoke(); },
                    OnHasCamera = () => { HasCamera?.Invoke(); },
                    OnHasMicrophone = () => { HasMicrophone?.Invoke(); },
                    OnNoCamera = () => { NoCamera?.Invoke(); },
                    OnCanceledByUser = () => { CanceledByUser?.Invoke(); }
                });
                Ziggeo.StartQrScanner();
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }

            return tcs.Task;
        }
    }
}