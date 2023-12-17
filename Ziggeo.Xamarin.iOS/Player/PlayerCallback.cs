using System;
using System.Collections.Generic;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class PlayerCallback : ZiggeoPlayerDelegate
    {
        public PlayerConfig Config { get; set; }

        public PlayerCallback(PlayerConfig config)
        {
            Config = config;
        }

        public override void PlayerCancelledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        public override void PlayerPaused()
        {
            Config.InvokePaused();
        }

        public override void PlayerEnded()
        {
            Config.InvokeEnded();
        }

        public override void PlayerPlaying()
        {
            Config.InvokePlaying();
        }

        public override void PlayerReadyToPlay()
        {
            Config.InvokeReadyToPlay();
        }

        public override void PlayerSeek(double positionMillis)
        {
            Config.InvokeSeek((int)positionMillis);
        }

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