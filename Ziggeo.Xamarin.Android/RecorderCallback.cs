using System.Collections.Generic;
using Com.Ziggeo.Androidsdk.Recorder;
using Java.Lang;

namespace Ziggeo
{
    public class RecorderCallback : Com.Ziggeo.Androidsdk.Callbacks.RecorderCallback
    {
        public IRecorderEventsListener Listener { get; set; }

        public RecorderCallback(IRecorderEventsListener listener)
        {
            Listener = listener;
        }

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            Listener.InvokeAccessForbidden(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            Listener.InvokeAccessGranted();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            Listener.InvokeCancelledByUser();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Listener.InvokeError(throwable);
        }

        public override void HasCamera()
        {
            base.HasCamera();
            Listener.InvokeHasCamera();
        }

        public override void HasMicrophone()
        {
            base.HasMicrophone();
            Listener.InvokeHasMicrophone();
        }

        public override void Loaded()
        {
            base.Loaded();
            Listener.InvokeLoaded();
        }

        public override void NoCamera()
        {
            base.NoCamera();
            Listener.InvokeNoCamera();
        }

        public override void NoMicrophone()
        {
            base.NoMicrophone();
            Listener.InvokeNoMicrophone();
        }

        public override void Countdown(int timeLeft)
        {
            base.Countdown(timeLeft);
            Listener.InvokeCountdown(timeLeft);
        }

        public override void ManuallySubmitted()
        {
            base.ManuallySubmitted();
            Listener.InvokeManuallySubmitted();
        }

        public override void MicrophoneHealth(MicSoundLevel micStatus)
        {
            base.MicrophoneHealth(micStatus);
            Listener.InvokeMicrophoneHealth(micStatus.ToString());
        }

        public override void ReadyToRecord()
        {
            base.ReadyToRecord();
            Listener.InvokeReadyToRecord();
        }

        public override void RecordingProgress(long time)
        {
            base.RecordingProgress(time);
            Listener.InvokeRecordingProgress(time);
        }

        public override void RecordingStarted()
        {
            base.RecordingStarted();
            Listener.InvokeRecordingStarted();
        }

        public override void RecordingStopped(string path)
        {
            base.RecordingStopped(path);
            Listener.InvokeRecordingStopped(path);
        }

        public override void StreamingStarted()
        {
            base.StreamingStarted();
            Listener.InvokeStreamingStarted();
        }

        public override void StreamingStopped()
        {
            base.StreamingStopped();
            Listener.InvokeStreamingStopped();
        }
    }
}