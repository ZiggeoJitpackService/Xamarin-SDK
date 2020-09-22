using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public class ScreenRecorderConfig : BaseConfig, IRecorderEventsListener
    {
        public event ErrorDelegate Error;
        public event LoadedDelegate Loaded;
        public event CanceledByUserDelegate CanceledByUser;
        public event AccessGrantedDelegate AccessGranted;
        public event AccessForbiddenDelegate AccessForbidden;
        public event NoMicrophoneDelegate NoMicrophone;
        public event HasMicrophoneDelegate HasMicrophone;
        public event HasCameraDelegate HasCamera;
        public event NoCameraDelegate NoCamera;
        public event MicrophoneHealthDelegate MicrophoneHealth;
        public event StreamingStartedDelegate StreamingStarted;
        public event StreamingStoppedDelegate StreamingStopped;
        public event RecordingStoppedDelegate RecordingStopped;
        public event ReadyToRecordDelegate ReadyToRecord;
        public event RecordingStartedDelegate RecordingStarted;
        public event RecordingProgressDelegate RecordingProgress;
        public event ManuallySubmittedDelegate ManuallySubmitted;
        public event CountdownDelegate Countdown;

        public void InvokeError(Exception e)
        {
            Error?.Invoke(e);
        }

        public void InvokeLoaded()
        {
            Loaded?.Invoke();
        }

        public void InvokeCancelledByUser()
        {
            CanceledByUser?.Invoke();
        }

        public void InvokeAccessGranted()
        {
            AccessGranted?.Invoke();
        }

        public void InvokeAccessForbidden(IList<string> permissions)
        {
            AccessForbidden?.Invoke(permissions);
        }

        public void InvokeNoMicrophone()
        {
            NoMicrophone?.Invoke();
        }

        public void InvokeHasMicrophone()
        {
            HasMicrophone?.Invoke();
        }

        public void InvokeHasCamera()
        {
            HasCamera?.Invoke();
        }

        public void InvokeNoCamera()
        {
            NoCamera?.Invoke();
        }

        public void InvokeMicrophoneHealth(string value)
        {
            MicrophoneHealth?.Invoke(value);
        }

        public void InvokeStreamingStarted()
        {
            StreamingStarted?.Invoke();
        }

        public void InvokeStreamingStopped()
        {
            StreamingStopped?.Invoke();
        }

        public void InvokeRecordingStopped(string path)
        {
            RecordingStopped?.Invoke(path);
        }

        public void InvokeReadyToRecord()
        {
            ReadyToRecord?.Invoke();
        }

        public void InvokeRecordingStarted()
        {
            RecordingStarted?.Invoke();
        }

        public void InvokeRecordingProgress(long timePassed)
        {
            RecordingProgress?.Invoke(timePassed);
        }

        public void InvokeManuallySubmitted()
        {
            ManuallySubmitted?.Invoke();
        }

        public void InvokeCountdown(int secondsLeft)
        {
            Countdown?.Invoke(secondsLeft);
        }
    }
}