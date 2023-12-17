using System;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class RecorderCallback : ZiggeoRecorderDelegate
    {
        public IRecorderEventsListener Listener { get; set; }

        public RecorderCallback(IRecorderEventsListener listener)
        {
            Listener = listener;
        }

        public override void RecorderCountdown(int secondsLeft)
        {
            Listener.InvokeCountdown(secondsLeft);
        }

        public override void RecorderReady()
        {
            Listener.InvokeReadyToRecord();
        }

        public override void RecorderStarted()
        {
            Listener.InvokeRecordingStarted();
        }

        public override void RecorderCurrentRecordedDurationSeconds(double seconds)
        {
            Listener.InvokeRecordingProgress((long)seconds);
        }

        public override void RecorderPaused()
        {
            throw new NotImplementedException();
        }

        public override void RecorderStopped(string path)
        {
            Listener.InvokeRecordingStopped(path);
        }

        public override void RecorderRerecord()
        {
            throw new NotImplementedException();
        }

        public override void RecorderPlaying()
        {
            throw new NotImplementedException();
        }

        public override void RecorderManuallySubmitted()
        {
            Listener.InvokeManuallySubmitted();
        }

        public override void StreamingStarted()
        {
            Listener.InvokeStreamingStarted();
        }

        public override void StreamingStopped()
        {
            Listener.InvokeStreamingStopped();
        }

        public override void RecorderCancelledByUser()
        {
            Listener.InvokeCancelledByUser();
        }
    }
}