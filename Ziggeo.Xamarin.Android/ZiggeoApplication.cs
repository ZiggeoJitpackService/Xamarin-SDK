using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Net;
using Com.Ziggeo.Androidsdk;
using Ziggeo.Services;
using Ziggeo.Xamarin.Android.Services;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
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

        public IZiggeo Ziggeo { get; private set; }

        public IVideos Videos { get; private set; }

        public IAudios Audios { get; private set; }

        public IImages Images { get; private set; }

        public IStreams Streams { get; private set; }
        
        public PlayerConfig PlayerConfig { get; set; }

        public void SetSensorManager(ISensorManagerEventsListener listener)
        {
            Ziggeo.SetSensorCallback(new SensorManagerCallback(listener));
        }

        public void StartPlayer(string videoToken)
        {
            _initConfigs();
            Ziggeo.StartPlayer(videoToken);
        }

        public void StartPlayerWithPath(string[] videoPath)
        {
            _initConfigs();
            var videoUris = videoPath.Select(Uri.Parse).ToArray();
            Ziggeo.StartPlayer(videoUris);
        }

        public void StartAudioWithToken(string[] mediaToken)
        {
            Ziggeo.StartAudioPlayer(mediaToken);
        }

        public void StartAudioWithPath(string[] mediaPath)
        {
            Ziggeo.StartAudioPlayer(mediaPath);
        }

        public void OpenImage(string mediaToken)
        {
            Ziggeo.ShowImage(mediaToken);
        }

        public void OpenImageWithPath(string mediaPath)
        {
            Ziggeo.ShowImage(mediaPath);
        }

        public void StartAudioRecorder()
        {
            Ziggeo.StartAudioRecorder();
        }

        public void StartImageRecorder()
        {
            Ziggeo.StartImageRecorder();
        }

        public FileSelectorConfig FileSelectorConfig { get; set; }

        public void StartFileSelector()
        {
            _initConfigs();
            Ziggeo.StartFileSelector();
        }

        public CameraRecorderConfig CameraRecorderConfig { get; set; }

        public void StartCameraRecorder()
        {
            _initConfigs();
            Ziggeo.StartCameraRecorder();
        }

        public QrScannerConfig QrScannerConfig { get; set; }

        public void StartQrScanner()
        {
            _initConfigs();
            Ziggeo.StartQrScanner();
        }

        public ScreenRecorderConfig ScreenRecorderConfig { get; set; }

        public void StartScreenRecorder()
        {
            _initConfigs();
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

        public UploaderConfig UploaderConfig { get; set; }

        public void CancelUpload(bool deleteFile)
        {
            Ziggeo.CancelCurrentUpload(deleteFile);
        }

        public void CancelUpload(string path, bool deleteFile)
        {
            Ziggeo.CancelUploadByPath(path, deleteFile);
        }

        public void CancelUpload(string path)
        {
            //todo true?
            Ziggeo.CancelUploadByPath(path, true);
        }

        public void SendReport(IList<LogModel> logModels)
        {
            Ziggeo.SendReport(LogModelMapper.Map(logModels));
        }

        private void _initConfigs()
        {
            if (Ziggeo == null)
            {
                Ziggeo = Com.Ziggeo.Androidsdk.Ziggeo.GetInstance(Application.Context);
            }

            Ziggeo.RecorderConfig = ScreenRecorderConfigMapper.Map(ScreenRecorderConfig);
            Ziggeo.QrScannerConfig = QrScannerConfigMapper.Map(QrScannerConfig);
            Ziggeo.FileSelectorConfig = FileSelectorConfigMapper.Map(FileSelectorConfig);
            Ziggeo.RecorderConfig = CameraRecorderConfigMapper.Map(CameraRecorderConfig);
            Ziggeo.PlayerConfig = PlayerConfigMapper.Map(PlayerConfig);
            Ziggeo.UploadingConfig = UploaderConfigMapper.Map(UploaderConfig);
        }

        private void _init()
        {
            if (Ziggeo == null)
            {
                Ziggeo = Com.Ziggeo.Androidsdk.Ziggeo.GetInstance(Application.Context);
            }

            Ziggeo.AppToken = _appToken;
            Videos = new ZiggeoVideosService(Ziggeo);
            Audios = new ZiggeoAudioService(Ziggeo);
            Images = new ZiggeoImageService(Ziggeo);
            Streams = new ZiggeoStreamsService(Ziggeo); 
        }
    }
}