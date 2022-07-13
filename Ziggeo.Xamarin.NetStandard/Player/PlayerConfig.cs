using System;
using System.Collections.Generic;

namespace Ziggeo
{
    public class PlayerConfig : BaseConfig, IPlayerEventsListener
    {
        public bool ShouldShowSubtitles;
        public bool IsMuted;
        
        public PlayerStyle PlayerStyle { get; set; }

        public event ErrorDelegate Error;
        public event LoadedDelegate Loaded;
        public event CanceledByUserDelegate CanceledByUser;
        public event AccessGrantedDelegate AccessGranted;
        public event AccessForbiddenDelegate AccessForbidden;
        public event PlayingDelegate Playing;
        public event PausedDelegate Paused;
        public event EndedDelegate Ended;
        public event SeekDelegate Seek;
        public event ReadyToPlayDelegate ReadyToPlay;

        public void InvokeError(Exception e)
        {
            Error?.Invoke(e);
        }

        public void InvokeLoaded()
        {
            Loaded?.Invoke();
        }

        public void InvokeCancelledByUser()
        {
            CanceledByUser?.Invoke();
        }

        public void InvokeAccessGranted()
        {
            AccessGranted?.Invoke();
        }

        public void InvokeAccessForbidden(IList<string> permissions)
        {
            AccessForbidden?.Invoke(permissions);
        }

        public void InvokePlaying()
        {
            Playing?.Invoke();
        }

        public void InvokePaused()
        {
            Paused?.Invoke();
        }

        public void InvokeEnded()
        {
            Ended?.Invoke();
        }

        public void InvokeSeek(int millis)
        {
            Seek?.Invoke(millis);
        }

        public void InvokeReadyToPlay()
        {
            ReadyToPlay?.Invoke();
        }
    }
}