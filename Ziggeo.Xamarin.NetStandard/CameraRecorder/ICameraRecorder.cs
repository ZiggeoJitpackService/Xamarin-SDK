using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public enum VideoDevice: uint
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
    public interface ICameraRecorder
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

        void StartRecorder();

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

        VideoDevice VideoDevice
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
