using System;

using UIKit;
using AVFoundation;
using AVKit;
using System.Threading.Tasks;

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

        public QrScanner(IZiggeoApplication application)
        {
            this.Application = application;
        }

        public IZiggeoApplication Application
        {
            get;
            private set;
        }

        public Task StartQrScanner()
        {
            throw new NotImplementedException();
        }
    }
}

