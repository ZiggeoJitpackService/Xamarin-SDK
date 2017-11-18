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

    public interface IZiggeoRecorder
    {
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
    }
}
