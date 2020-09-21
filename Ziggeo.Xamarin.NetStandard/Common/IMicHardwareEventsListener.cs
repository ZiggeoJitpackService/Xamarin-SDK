using System;

namespace Ziggeo
{
    public delegate void NoMicrophoneDelegate();

    public delegate void HasMicrophoneDelegate();

    public delegate void MicrophoneHealthDelegate(string value);

    public interface IMicHardwareEventsListener : IErrorEventsListener
    {
        event NoMicrophoneDelegate NoMicrophone;
        void InvokeNoMicrophone();
        event HasMicrophoneDelegate HasMicrophone;
        void InvokeHasMicrophone();
        event MicrophoneHealthDelegate MicrophoneHealth;
        void InvokeMicrophoneHealth(string value);
    }
}