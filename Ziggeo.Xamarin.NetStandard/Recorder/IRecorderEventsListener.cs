using System;
using Ziggeo;

namespace Ziggeo
{
    public delegate void RecordingStoppedDelegate(string path);

    public delegate void ReadyToRecordDelegate();

    public delegate void RecordingStartedDelegate();

    public delegate void RecordingProgressDelegate(int secondsPassed);

    public delegate void ManuallySubmittedDelegate();

    public delegate void CountdownDelegate(int secondsLeft);

    public interface IRecorderEventsListener : ICommonEventsListener, IPermissionEventsListener,
        IHardwareEventsListener,
        IStreamingEventsListener
    {
        event RecordingStoppedDelegate RecordingStopped;
        event ReadyToRecordDelegate ReadyToRecord;
        event RecordingStartedDelegate RecordingStarted;
        event RecordingProgressDelegate RecordingProgress;
        event ManuallySubmittedDelegate ManuallySubmitted;
        event CountdownDelegate Countdown;
    }
}