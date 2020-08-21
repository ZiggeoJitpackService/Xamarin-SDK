using Ziggeo;

namespace Ziggeo
{
    public delegate void StreamingStartedDelegate();

    public delegate void StreamingStoppedDelegate();


    public interface IStreamingEventsListener : IErrorEventsListener
    {
        event StreamingStartedDelegate StreamingStarted;
        event StreamingStoppedDelegate StreamingStopped;
    }
}