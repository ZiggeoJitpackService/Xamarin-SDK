using System;

namespace Ziggeo
{
    public delegate void HasCameraDelegate();

    public delegate void NoCameraDelegate();

    public interface ICameraHardwareEventsListener : IErrorEventsListener
    {
        event HasCameraDelegate HasCamera;
        void InvokeHasCamera();
        event NoCameraDelegate NoCamera;
        void InvokeNoCamera();
    }
}