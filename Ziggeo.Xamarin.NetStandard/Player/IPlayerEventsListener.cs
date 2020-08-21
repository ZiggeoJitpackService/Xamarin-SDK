using Ziggeo;

namespace Ziggeo
{
    public delegate void PlayingDelegate();

    public delegate void PausedDelegate();

    public delegate void EndedDelegate();

    public delegate void SeekDelegate(int millis);

    public delegate void ReadyToPlayDelegate();

    public interface IPlayerEventsListener : ICommonEventsListener, IPermissionEventsListener{
        event PlayingDelegate Playing;
        event PausedDelegate Paused;
        event EndedDelegate Ended;
        event SeekDelegate Seek;
        event ReadyToPlayDelegate ReadyToPlay;
    }
}