using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public class CameraRecorderConfig : BaseConfig, IRecorderEventsListener
    {
        public const int DefaultStartDelay = 3; // seconds

        public enum CameraFacing : uint
        {
            Rear = 0,
            Front
        }

        public enum Quality : uint
        {
            High = 0,
            Medium,
            Low
        }

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
        public event RerecordDelegate Rerecord;
        public event RecordingStartedDelegate RecordingStarted;
        public event RecordingProgressDelegate RecordingProgress;
        public event ManuallySubmittedDelegate ManuallySubmitted;
        public event CountdownDelegate Countdown;

        public bool ShouldShowFaceOutline { get; set; }
        public bool IsLiveStreaming { get; set; }
        public bool ShouldAutoStartRecording { get; set; }
        public int StartDelay { get; set; } = DefaultStartDelay;
        public bool BlurMode { get; set; } = false;
        public bool ShouldSendImmediately { get; set; } = true;
        public bool ShouldDisableCameraSwitch { get; set; }
        public int VideoQuality { get; set; }
        public int Facing { get; set; }
        public long MaxDuration { get; set; }
        public bool ShouldEnableCoverShot { get; set; } = true;
        public bool ShouldConfirmStopRecording { get; set; }
        public StopRecordingConfirmationDialogConfig StopRecordingConfirmationDialogConfig { get; set; }

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

        public void InvokeRerecord()
        {
            Rerecord?.Invoke();
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