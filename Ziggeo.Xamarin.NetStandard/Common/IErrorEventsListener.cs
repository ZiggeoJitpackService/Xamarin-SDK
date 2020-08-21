using System;

namespace Ziggeo
{
    public delegate void ErrorDelegate(Exception ex);

    public interface IErrorEventsListener
    {
        event ErrorDelegate Error;
    }
}