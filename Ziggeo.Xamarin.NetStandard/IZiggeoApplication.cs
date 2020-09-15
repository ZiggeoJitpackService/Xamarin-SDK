using System;

namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string AppToken { get; }

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
    }
}