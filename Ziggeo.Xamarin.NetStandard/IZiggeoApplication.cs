using System;
using System.Collections.Generic;

namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string AppToken { get; set; }

        string ServerAuthToken { get; set; }

        string ClientAuthToken { get; set; }

        IVideos Videos { get; }

        IStreams Streams { get; }

        CameraRecorderConfig CameraRecorderConfig { get; set; }
        void StartCameraRecorder();

        QrScannerConfig QrScannerConfig { get; set; }
        void StartQrScanner();

        ScreenRecorderConfig ScreenRecorderConfig { get; set; }
        void StartScreenRecorder();

        PlayerConfig PlayerConfig { get; set; }
        void StartPlayer(string videoToken);

        FileSelectorConfig FileSelectorConfig { get; set; }
        void StartFileSelector();

        UploaderConfig UploaderConfig { get; set; }

        void SendReport(IList<LogModel> logModels);
    }
}