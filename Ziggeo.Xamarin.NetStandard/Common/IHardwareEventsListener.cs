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
        event HasMicrophoneDelegate HasMicrophone;
        event HasCameraDelegate HasCamera;
        event NoCameraDelegate NoCamera;
        event MicrophoneHealthDelegate MicrophoneHealth;
    }
}