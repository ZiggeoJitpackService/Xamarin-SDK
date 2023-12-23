using System;
using System.Collections.Generic;
using Ziggeo.Xamarin.iOS.Services;
using AVFoundation;
using ZiggeoMediaSDK;


namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        private string _appToken;
        private ZiggeoMediaSDK.Ziggeo _ziggeo;
        private ZiggeoConnect Connect { get; set; }

        public QrScannerConfig QrScannerConfig { get; set; }
        public FileSelectorConfig FileSelectorConfig { get; set; }
        public PlayerConfig PlayerConfig { get; set; }
        public UploaderConfig UploaderConfig { get; set; }
        public CameraRecorderConfig CameraRecorderConfig { get; set; }
        public ScreenRecorderConfig ScreenRecorderConfig { get; set; }

        public IVideos Videos { get; private set; }
        public IAudios Audios { get; private set; }
        public IImages Images { get; private set; }
        public IPlayer Player { get; private set; }
        public IStreams Streams { get; private set; }


        public ZiggeoApplication()
        {
            AppToken = "";
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

        private void _init()
        {
            _ziggeo = new ZiggeoMediaSDK.Ziggeo(_appToken);

            Connect = _ziggeo.Connect;
            Videos = new ZiggeoVideosService(_ziggeo);
            Audios = new ZiggeoAudioService(_ziggeo);
            Images = new ZiggeoImageService(_ziggeo);
            //Streams = new ZiggeoStreamsService(Ziggeo);

            ServerAuthToken = "";
            ClientAuthToken = "";          

            AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.PlayAndRecord,
                AVAudioSessionCategoryOptions.DuckOthers | AVAudioSessionCategoryOptions.DefaultToSpeaker);
        }

        private void _initConfigs()
        {
            if (_ziggeo == null)
            {
                _ziggeo = new ZiggeoMediaSDK.Ziggeo(_appToken);
            }
    
            if (QrScannerConfig != null)
            {
                _ziggeo.QrScannerConfig = QrScannerConfigMapper.Map(QrScannerConfig);
                _ziggeo.SetQRScannerDelegate(new QrScannerCallback(QrScannerConfig));
                _ziggeo.SetHardwarePermissionDelegate(new HardwarePermissionQRScannerCallback(QrScannerConfig));
            }

            if (FileSelectorConfig != null)
            {
                _ziggeo.FileSelectorConfig = FileSelectorConfigMapper.Map(FileSelectorConfig);
                _ziggeo.SetFileSelectorDelegate(new FileSelectorCallback(FileSelectorConfig));
            }

            if (PlayerConfig != null)
            { 
                _ziggeo.PlayerConfig = PlayerConfigMapper.Map(PlayerConfig);
                _ziggeo.SetPlayerDelegate(new PlayerCallback(PlayerConfig));
            }

            if (UploaderConfig != null)
            {
                _ziggeo.UploadingConfig = UploaderConfigMapper.Map(UploaderConfig);
                _ziggeo.SetUploadingDelegate(new UploaderCallback(UploaderConfig));
            }

            if (ScreenRecorderConfig != null)
            {
                _ziggeo.RecorderConfig = ScreenRecorderConfigMapper.Map(ScreenRecorderConfig);
            }

            if (CameraRecorderConfig != null)
            {
                    _ziggeo.RecorderConfig = CameraRecorderConfigMapper.Map(CameraRecorderConfig);
                    _ziggeo.SetRecorderDelegate(new RecorderCallback(CameraRecorderConfig));
                    _ziggeo.SetHardwarePermissionDelegate(new HardwarePermissionRecorderCallback(CameraRecorderConfig));
            }
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


        // QR Scanner
        public void StartQrScanner()
        {
            ZiggeoMediaSDK.Ziggeo qrZiggeo = new ZiggeoMediaSDK.Ziggeo();
            qrZiggeo.QrScannerConfig = QrScannerConfigMapper.Map(QrScannerConfig);
            qrZiggeo.SetQRScannerDelegate(new QrScannerCallback(QrScannerConfig));
            qrZiggeo.SetHardwarePermissionDelegate(new HardwarePermissionQRScannerCallback(QrScannerConfig));
            qrZiggeo.StartQrScanner();
        }

        public void SetSensorManager(ISensorManagerEventsListener listener)
        {
            //_ziggeo.SetSensorCallback(new SensorManagerCallback(listener));
            throw new NotImplementedException();
        }

        public void StartPlayer(string videoToken)
        {
            _initConfigs();
            _ziggeo.PlayVideo(videoToken);
        }

        public void StartPlayerWithPath(string[] videoPath)
        {
            _initConfigs();
            //string[] tokens = new string[1];
            //tokens[0] = videoToken;
            _ziggeo.PlayVideos(videoPath);
        }

        public void StartAudioWithToken(string[] mediaToken)
        {
            _initConfigs();
            _ziggeo.PlayAudios(mediaToken);
        }

        public void StartAudioWithPath(string[] mediaPath)
        {
            _initConfigs();
            _ziggeo.PlayAudioFromUris(mediaPath);
        }

        public void OpenImage(string mediaToken)
        {
            _initConfigs();
            _ziggeo.ShowImage(mediaToken);
        }

        public void OpenImageWithPath(string mediaPath)
        {
            _initConfigs();
            _ziggeo.ShowImage(mediaPath);
        }

        public void StartAudioRecorder()
        {
            _initConfigs();
            _ziggeo.StartAudioRecorder();
        }

        public void StartImageRecorder()
        {
            _initConfigs();
            _ziggeo.StartImageRecorder();
        }

        public void StartFileSelector()
        {
            _initConfigs();
            _ziggeo.StartFileSelector();
        }

        public void StartCameraRecorder()
        {
            _initConfigs();
            _ziggeo.Record();
        }

        public void StartScreenRecorder()
        {
            _initConfigs();
            _ziggeo.StartScreenRecorderWithAppGroup("", "");
        }

        public void CancelUpload(bool deleteFile)
        {
            _ziggeo.CancelUpload("", deleteFile);
        }

        public void CancelUpload(string path, bool deleteFile)
        {
            _ziggeo.CancelUpload(path, deleteFile);
        }

        public void CancelUpload(string path)
        {
            _ziggeo.CancelUpload(path, true);
        }

        public void SendReport(IList<LogModel> logModels)
        {
            _ziggeo.SendReport(LogModelMapper.Map(logModels));
        }
    }
}