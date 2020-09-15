using System;
using Ziggeo.Services;
using AVFoundation;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        private readonly ICameraRecorder _cameraRecorder;

        public ZiggeoApplication(string token)
        {
            this.AppToken = token;
            Connect = new ZiggeoConnectImpl(token);
            this.Streams = new ZiggeoStreamsService(Connect);
            this.Videos = new ZiggeoVideosService(Connect, Streams);

            this._cameraRecorder = new CameraRecorder(this);
            this.Player = new Player(this, Connect);

            AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.PlayAndRecord,
                AVAudioSessionCategoryOptions.DuckOthers | AVAudioSessionCategoryOptions.DefaultToSpeaker);
        }

        public string AppToken { get; private set; }

        public ZiggeoConnect Connect { get; set; }

        public IVideos Videos { get; private set; }

        public IStreams Streams { get; private set; }

        public IPlayer Player { get; }
        public void StartCameraRecorder()
        {
            _cameraRecorder.StartRecorder();
        }

        public void StartQrScanner()
        {
            throw new NotImplementedException();
        }

        public CameraRecorderConfig CameraRecorderConfig { get; set; }
        public QrScannerConfig QrScannerConfig { get; set; }
        public ScreenRecorderConfig ScreenRecorderConfig { get; set; }
        public void StartScreenRecorder()
        {
            throw new NotImplementedException();
        }

        public PlayerConfig PlayerConfig { get; set; }
        public void StartPlayer(string videoToken)
        {
            throw new NotImplementedException();
        }

        public FileSelectorConfig FileSelectorConfig { get; set; }
        public void StartFileSelector()
        {
            throw new NotImplementedException();
        }

        public string ServerAuthToken
        {
            get => Connect.ServerAuthToken;
            set => Connect.ServerAuthToken = value;
        }

        public string ClientAuthToken
        {
            get => Connect.ClientAuthToken;
            set => Connect.ClientAuthToken = value;
        }

    }
}