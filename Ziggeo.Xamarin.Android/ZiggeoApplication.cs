using System;
using Android.Content;
using Com.Ziggeo.Androidsdk;
using Ziggeo.Services;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {

        public ZiggeoApplication(string token)
        {
            this.AppToken = token;
            this.Ziggeo = new Com.Ziggeo.Androidsdk.Ziggeo(token, Android.App.Application.Context);
            this.Videos = new ZiggeoVideosService(Ziggeo);
            this.Streams = new ZiggeoStreamsService(Ziggeo);
        }

        public string AppToken { get; private set; }

        public IZiggeo Ziggeo { get; private set; }

        public IVideos Videos { get; private set; }

        public IStreams Streams { get; private set; }

        public PlayerConfig PlayerConfig { get; set; }

        public void StartPlayer(string videoToken)
        {
            Ziggeo.StartPlayer(videoToken);
        }

        public FileSelectorConfig FileSelectorConfig { get; set; }

        public void StartFileSelector()
        {
            Ziggeo.StartFileSelector();
        }

        public CameraRecorderConfig CameraRecorderConfig { get; set; }

        public void StartCameraRecorder()
        {
            Ziggeo.RecorderConfig = CameraRecorderConfigMapper.map(CameraRecorderConfig);
            Ziggeo.StartCameraRecorder();
        }

        public QrScannerConfig QrScannerConfig { get; set; }

        public void StartQrScanner()
        {
            Ziggeo.QrScannerConfig = QrScannerConfigMapper.map(QrScannerConfig);
            Ziggeo.StartQrScanner();
        }

        public ScreenRecorderConfig ScreenRecorderConfig { get; set; }

        public void StartScreenRecorder()
        {
            Ziggeo.RecorderConfig = CameraRecorderConfigMapper.map(CameraRecorderConfig);
            Ziggeo.StartScreenRecorder(null);
        }

        public string ServerAuthToken
        {
            get => Ziggeo.ServerAuthToken;
            set => Ziggeo.ServerAuthToken = value;
        }

        public string ClientAuthToken
        {
            get => Ziggeo.ClientAuthToken;
            set => Ziggeo.ClientAuthToken = value;
        }
    }
}