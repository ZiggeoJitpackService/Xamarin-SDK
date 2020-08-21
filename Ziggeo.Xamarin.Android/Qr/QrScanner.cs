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
                //TODO
                Ziggeo.QrScannerConfig = new QrScannerConfig(ShouldCloseAfterSuccessfulScan, new QrScannerCallback
                {
                    OnError = throwable => { Console.WriteLine("OnError:" + throwable); },
                    OnDecoded = qr => { Console.WriteLine("OnDecoded:" + qr); },
                    OnLoaded = () => { Console.WriteLine("OnLoaded"); },
                    OnAccessForbidden = permissions => { Console.WriteLine("OnAccessForbidden:" + permissions); },
                    OnAccessGranted = () => { Console.WriteLine("OnAccessGranted"); },
                    OnHasCamera = () => { Console.WriteLine("OnHasCamera"); },
                    OnHasMicrophone = () => { Console.WriteLine("OnHasMicrophone"); },
                    OnMicrophoneHealth = health => { Console.WriteLine("OnMicrophoneHealth:" + health); },
                    OnNoCamera = () => { Console.WriteLine("OnNoCamera"); },
                    OnNoMicrophone = () => { Console.WriteLine("OnNoMicrophone"); },
                    OnCanceledByUser = () => { Console.WriteLine("OnCanceledByUser"); }
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