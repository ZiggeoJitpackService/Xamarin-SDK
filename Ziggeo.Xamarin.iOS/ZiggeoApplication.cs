using System;
using System.Collections.Generic;
using Ziggeo.Services;
using AVFoundation;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        private CameraRecorder _cameraRecorder;
        private string _appToken;

        public ZiggeoApplication()
        {
        }

        public ZiggeoApplication(string token)
        {
            AppToken = token;
        }

        public string AppToken
        {
            get => _appToken;
            set
            {
                _appToken = value;
                _init();
            }
        }

        public ZiggeoConnect Connect { get; set; }

        public IVideos Videos { get; private set; }

        public IStreams Streams { get; private set; }
        
        public IZVideoView ZVideoView { get; }
        
        public IZCameraView ZCameraView { get; }

        public IPlayer Player { get; private set; }

        public void SetSensorManager(ISensorManagerEventsListener callback)
        {
            throw new NotImplementedException();
        }

        public void StartCameraRecorder()
        {
            _cameraRecorder.StartRecorder();
        }
        
        public void StartAudio(string mediaToken, string mediaPath)
        {
        }

        public void StartAudioWithPath(string[] mediaPath)
        {
            throw new NotImplementedException();
        }
        
        public void StartAudioWithToken(string[] mediaToken)
        {
            throw new NotImplementedException();
        }

        public void OpenImage(string mediaToken)
        {
        }
        
        public void StartAudioRecorder()
        {
        }
        
        public void StartImageRecorder()
        {
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

        public void StartAudioWithToken(string mediaToken)
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

        public UploaderConfig UploaderConfig { get; set; }

        public IAudios Audios => throw new NotImplementedException();

        public IImages Images => throw new NotImplementedException();

        public void SendReport(IList<LogModel> logModels)
        {
            throw new NotImplementedException();
        }

        public void CancelUpload(bool deleteFile)
        {
            throw new NotImplementedException();
        }

        public void CancelUpload(string path, bool deleteFile)
        {
            throw new NotImplementedException();
        }

        public void CancelUpload(string path)
        {
            throw new NotImplementedException();
        }

        private void _init()
        {
            Connect = new ZiggeoConnectImpl(_appToken);
            Streams = new ZiggeoStreamsService(Connect);
            Videos = new ZiggeoVideosService(Connect, Streams);

            _cameraRecorder = new CameraRecorder(this);
            Player = new Player(this, Connect);

            AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.PlayAndRecord,
                AVAudioSessionCategoryOptions.DuckOthers | AVAudioSessionCategoryOptions.DefaultToSpeaker);
        }
    }
}