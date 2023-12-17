using System;
using System.Collections.Generic;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class HardwarePermissionRecorderCallback : ZiggeoHardwarePermissionDelegate
    {
        public IRecorderEventsListener Config { get; set; }

        public HardwarePermissionRecorderCallback(IRecorderEventsListener config)
        {
            Config = config;
        }

        public override void CheckCameraPermission(bool granted)
        {
            if (granted)
            {
                Config.InvokeAccessGranted();
            }
            else
            {
                string[] permissions = new string[1];
                permissions[0] = "Camera";
                Config.InvokeAccessForbidden(permissions);
            }
        }

        public override void CheckMicrophonePermission(bool granted)
        {
            if (granted)
            {
                Config.InvokeAccessGranted();
            }
            else
            {
                string[] permissions = new string[1];
                permissions[0] = "Microphone";
                Config.InvokeAccessForbidden(permissions);
            }
        }

        public override void CheckPhotoLibraryPermission(bool granted)
        {
            if (granted)
            {
                Config.InvokeAccessGranted();
            }
            else
            {
                string[] permissions = new string[1];
                permissions[0] = "PhotoLibrary";
                Config.InvokeAccessForbidden(permissions);
            }
        }

        public override void CheckHasCamera(bool hasCamera)
        {
            if (hasCamera)
            {
                Config.InvokeHasCamera();
            }
            else
            {
                Config.InvokeNoCamera();
            }
        }

        public override void CheckHasMicrophone(bool hasMicrophone)
        {
            if (hasMicrophone)
            {
                Config.InvokeHasMicrophone();
            }
            else
            {
                Config.InvokeNoMicrophone();
            }
        }

        //public override void MicrophoneHealth(MicSoundLevel micStatus)
        //{
        //    Config.InvokeMicrophoneHealth(micStatus.ToString());
        //}


        // Common
        public void AccessForbidden(IList<string> permissions)
        {
            Config.InvokeAccessForbidden(permissions);
        }

        public void AccessGranted()
        {
            Config.InvokeAccessGranted();
        }

        public void CanceledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        public void Error(Exception throwable)
        {
            Config.InvokeError(throwable);
        }

        public void Loaded()
        {
            Config.InvokeLoaded();
        }
    }
}