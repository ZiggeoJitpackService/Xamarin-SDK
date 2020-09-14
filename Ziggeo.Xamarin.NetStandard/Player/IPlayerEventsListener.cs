using Ziggeo;

namespace Ziggeo
{
    public delegate void PlayingDelegate();

    public delegate void PausedDelegate();

    public delegate void EndedDelegate();

    public delegate void SeekDelegate(int millis);

    public delegate void ReadyToPlayDelegate();

    public interface IPlayerEventsListener : ICommonEventsListener, IPermissionEventsListener
    {
        event PlayingDelegate Playing;
        void InvokePlaying();
        event PausedDelegate Paused;
        void InvokePaused();
        event EndedDelegate Ended;
        void InvokeEnded();
        event SeekDelegate Seek;
        void InvokeSeek(int millis);
        event ReadyToPlayDelegate ReadyToPlay;
        void InvokeReadyToPlay();
    }
}