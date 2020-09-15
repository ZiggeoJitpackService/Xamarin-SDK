using System;

namespace Ziggeo
{
    public delegate void NoMicrophoneDelegate();

    public delegate void HasMicrophoneDelegate();

    public delegate void HasCameraDelegate();

    public delegate void NoCameraDelegate();

    public delegate void MicrophoneHealthDelegate(string value);

    public interface IHardwareEventsListener : IErrorEventsListener
    {
        event NoMicrophoneDelegate NoMicrophone;
        void InvokeNoMicrophone();
        event HasMicrophoneDelegate HasMicrophone;
        void InvokeHasMicrophone();
        event HasCameraDelegate HasCamera;
        void InvokeHasCamera();
        event NoCameraDelegate NoCamera;
        void InvokeNoCamera();
        event MicrophoneHealthDelegate MicrophoneHealth;
        void InvokeMicrophoneHealth(string value);
    }
}