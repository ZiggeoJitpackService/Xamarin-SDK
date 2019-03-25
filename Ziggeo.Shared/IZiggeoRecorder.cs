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
    public interface IZiggeoRecorder
    {
        event RecorderDelegate RecordingStarted;
        event RecorderDelegate RecordingStopped;
        event RecorderDelegate RecordingCanceled;
        event RecordingFinishedDelegate RecordingFinishedUploadDone;
        event RecorderErrorDelegate RecordingError;

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
        
        VideoQuality VideoQuality
        {
            get;
            set;
        }

        double MaxRecordingDurationSeconds
        {           
            get;
            set;
        }
    }
}
