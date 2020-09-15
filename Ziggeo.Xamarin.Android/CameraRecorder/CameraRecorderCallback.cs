using System.Collections.Generic;
using Com.Ziggeo.Androidsdk.Recorder;
using Java.Lang;

namespace Ziggeo
{
    public class CameraRecorderCallback : Com.Ziggeo.Androidsdk.Callbacks.RecorderCallback
    {
        public CameraRecorderConfig Config { get; set; }

        public CameraRecorderCallback(CameraRecorderConfig config)
        {
            Config = config;
        }

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            Config.InvokeAccessForbidden(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            Config.InvokeAccessGranted();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            Config.InvokeCancelledByUser();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Config.InvokeError(throwable);
        }

        public override void HasCamera()
        {
            base.HasCamera();
            Config.InvokeHasCamera();
        }

        public override void HasMicrophone()
        {
            base.HasMicrophone();
            Config.InvokeHasMicrophone();
        }

        public override void Loaded()
        {
            base.Loaded();
            Config.InvokeLoaded();
        }

        public override void NoCamera()
        {
            base.NoCamera();
            Config.InvokeNoCamera();
        }

        public override void NoMicrophone()
        {
            base.NoMicrophone();
            Config.InvokeNoMicrophone();
        }

        public override void Countdown(int timeLeft)
        {
            base.Countdown(timeLeft);
            Config.InvokeCountdown(timeLeft);
        }

        public override void ManuallySubmitted()
        {
            base.ManuallySubmitted();
            Config.InvokeManuallySubmitted();
        }

        public override void MicrophoneHealth(MicSoundLevel micStatus)
        {
            base.MicrophoneHealth(micStatus);
            Config.InvokeMicrophoneHealth(micStatus.ToString());
        }

        public override void ReadyToRecord()
        {
            base.ReadyToRecord();
            Config.InvokeReadyToRecord();
        }

        public override void RecordingProgress(long time)
        {
            base.RecordingProgress(time);
            Config.InvokeRecordingProgress(time);
        }

        public override void RecordingStarted()
        {
            base.RecordingStarted();
            Config.InvokeRecordingStarted();
        }

        public override void RecordingStopped(string path)
        {
            base.RecordingStopped(path);
            Config.InvokeRecordingStopped(path);
        }

        public override void StreamingStarted()
        {
            base.StreamingStarted();
            Config.InvokeStreamingStarted();
        }

        public override void StreamingStopped()
        {
            base.StreamingStopped();
            Config.InvokeStreamingStopped();
        }
    }
}