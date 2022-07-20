using System.Collections.Generic;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string AppToken { get; set; }

        string ServerAuthToken { get; set; }

        string ClientAuthToken { get; set; }

        IVideos Videos { get; }

        IAudios Audios { get; }

        IImages Images { get; }

        IStreams Streams { get; }
        
        IZVideoView ZVideoView { get; }
        
        IZCameraView ZCameraView{ get; }

        CameraRecorderConfig CameraRecorderConfig { get; set; }
        
        void SetSensorManager(ISensorManagerEventsListener callback);
        
        void StartCameraRecorder();

        QrScannerConfig QrScannerConfig { get; set; }
        void StartQrScanner();

        ScreenRecorderConfig ScreenRecorderConfig { get; set; }
        void StartScreenRecorder();

        PlayerConfig PlayerConfig { get; set; }
        void StartPlayer(string videoToken);

        void StartAudioWithToken(string[] mediaToken);

        void StartAudioWithPath(string[] mediaPath);

        void OpenImage(string mediaToken);

        void StartAudioRecorder();

        void StartImageRecorder();

        FileSelectorConfig FileSelectorConfig { get; set; }
        void StartFileSelector();

        UploaderConfig UploaderConfig { get; set; }

        void CancelUpload(bool deleteFile);

        void CancelUpload(string path, bool deleteFile);

        void CancelUpload(string path);

        void SendReport(IList<LogModel> logModels);
    }
}