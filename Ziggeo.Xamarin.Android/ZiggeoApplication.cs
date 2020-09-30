using System;
using System.Collections.Generic;
using Com.Ziggeo.Androidsdk;
using Ziggeo.Services;

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

        public IStreams Streams { get; private set; }

        public PlayerConfig PlayerConfig { get; set; }

        public void StartPlayer(string videoToken)
        {
            _initConfigs();
            Ziggeo.StartPlayer(videoToken);
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

        public void SendReport(IList<LogModel> logModels)
        {
            Ziggeo.SendReport(LogModelMapper.Map(logModels));
        }

        public void SendEmailToSupport()
        {
            Ziggeo.SendEmailToSupport();
        }

        private void _initConfigs()
        {
            Ziggeo.RecorderConfig = ScreenRecorderConfigMapper.Map(ScreenRecorderConfig);
            Ziggeo.QrScannerConfig = QrScannerConfigMapper.Map(QrScannerConfig);
            Ziggeo.FileSelectorConfig = FileSelectorConfigMapper.Map(FileSelectorConfig);
            Ziggeo.RecorderConfig = CameraRecorderConfigMapper.Map(CameraRecorderConfig);
            Ziggeo.PlayerConfig = PlayerConfigMapper.Map(PlayerConfig);
            Ziggeo.UploadingConfig = UploaderConfigMapper.Map(UploaderConfig);
        }

        private void _init()
        {
            Ziggeo = new Com.Ziggeo.Androidsdk.Ziggeo(_appToken, Android.App.Application.Context);
            Videos = new ZiggeoVideosService(Ziggeo);
            Streams = new ZiggeoStreamsService(Ziggeo);
        }
    }
}