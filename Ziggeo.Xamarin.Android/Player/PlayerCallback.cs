using System;
using System.Collections.Generic;
using Java.Lang;

namespace Ziggeo
{
    public class PlayerCallback : Com.Ziggeo.Androidsdk.Callbacks.PlayerCallback
    {
        public PlayerConfig Config { get; set; }

        public PlayerCallback(PlayerConfig config)
        {
            Config = config;
        }

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            Config.InvokeAccessForbidden(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            Config.InvokeAccessGranted();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            Config.InvokeCancelledByUser();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Config.InvokeError(throwable);
        }

        public override void Loaded()
        {
            base.Loaded();
            Config.InvokeLoaded();
        }

        public override void Ended()
        {
            base.Ended();
            Config.InvokeEnded();
        }

        public override void Paused()
        {
            base.Paused();
            Config.InvokePaused();
        }

        public override void Playing()
        {
            base.Playing();
            Config.InvokePlaying();
        }

        public override void ReadyToPlay()
        {
            base.ReadyToPlay();
            Config.InvokeReadyToPlay();
        }

        public override void Seek(long millis)
        {
            base.Seek(millis);
            Config.InvokeSeek((int) millis);
        }
    }
}