using System;
using Ziggeo;

namespace Ziggeo
{
    public delegate void RecordingStoppedDelegate(string path);

    public delegate void ReadyToRecordDelegate();

    public delegate void RecordingStartedDelegate();

    public delegate void RecordingProgressDelegate(long timePassed);

    public delegate void ManuallySubmittedDelegate();

    public delegate void CountdownDelegate(int secondsLeft);

    public interface IRecorderEventsListener : ICommonEventsListener, IPermissionEventsListener,
        IMicHardwareEventsListener, ICameraHardwareEventsListener, IStreamingEventsListener
    {
        event RecordingStoppedDelegate RecordingStopped;
        void InvokeRecordingStopped(string path);
        event ReadyToRecordDelegate ReadyToRecord;
        void InvokeReadyToRecord();
        event RecordingStartedDelegate RecordingStarted;
        void InvokeRecordingStarted();
        event RecordingProgressDelegate RecordingProgress;
        void InvokeRecordingProgress(long timePassed);
        event ManuallySubmittedDelegate ManuallySubmitted;
        void InvokeManuallySubmitted();
        event CountdownDelegate Countdown;
        void InvokeCountdown(int secondsLeft);
    }
}