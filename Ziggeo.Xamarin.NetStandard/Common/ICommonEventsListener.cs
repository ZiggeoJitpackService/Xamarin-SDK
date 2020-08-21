using System;

namespace Ziggeo
{
    public delegate void LoadedDelegate();

    public delegate void CanceledByUserDelegate();

    public interface ICommonEventsListener : IErrorEventsListener
    {
        event LoadedDelegate Loaded;
        event CanceledByUserDelegate CanceledByUser;
    }
}