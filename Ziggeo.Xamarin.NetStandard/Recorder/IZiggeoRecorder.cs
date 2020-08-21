using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public enum ZiggeoVideoDevice: uint
    {
        Rear = 0,
        Front
    };

    public enum VideoQuality: uint
    {
        High = 0,
        Medium,
        Low
    };

    public delegate void RecorderDelegate();
    public delegate void RecorderErrorDelegate(Exception ex);
    public delegate void RecordingFinishedDelegate(string token);
    public delegate void RecordingDurationDelegate(double duration);
    public delegate void LuxMeterDelegate(double luminosity);
    public delegate void AudioMeterDelegate(double audioLevel);
    public delegate void FaceDetectorDelegate(int faceID, double x, double y, double width, double height);
    public interface IZiggeoRecorder
    {
        event RecorderDelegate RecordingStarted;
        event RecorderDelegate RecordingStopped;
        event RecorderDelegate RecordingCanceled;
        event RecordingDurationDelegate RecordingDurationUpdated;
        event RecordingFinishedDelegate RecordingFinishedUploadDone;
        event RecorderErrorDelegate RecordingError;
        event LuxMeterDelegate LuminosityUpdated;
        event AudioMeterDelegate AudioLevelUpdated;
        event FaceDetectorDelegate FaceDetected;

        Task<string> Record();

        bool CoverSelectorEnabled
        {
            get;
            set;
        }

        Dictionary<string, string> AdditionalParameters
        {
            get;
            set;
        }

        bool CameraFlipButtonVisible
        {
            get;
            set;
        }

        ZiggeoVideoDevice VideoDevice
        {
            get;
            set;
        }

        double MaxRecordingDurationSeconds
        {           
            get;
            set;
        }

        VideoQuality VideoQuality
        {
            get;
            set;
        }

        bool ShowLightIndicator
        {
            get;
            set;
        }

        bool ShowAudioIndicator
        {
            get;
            set;
        }

        bool ShowFaceOutline
        {
            get;
            set;
        }
    }
}
