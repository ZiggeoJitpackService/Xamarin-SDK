using System;

using UIKit;
using AVFoundation;
using AVKit;
using System.Threading.Tasks;

namespace Ziggeo
{
    public partial class Player : AVPlayerViewController, IPlayer
    {
        delegate void PlayerDelegate();
        event PlayerDelegate DismissingNow = null;

        public Player(IZiggeoApplication application, ZiggeoConnect connect) : base("Player", null)
        {
            this.Application = application;
            this.Connect = connect;
        }

        public IZiggeoApplication Application
        {
            get;
            private set;
        }

        protected ZiggeoConnect Connect
        {
            get;
            private set;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            DismissingNow?.Invoke();
        }

        public async Task StartPlayer(string videoToken)
        {
            TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
            try
            {
                string videoURL = Application.Videos.GetVideoUrl(videoToken).AbsoluteUri;
                var sessionData = await Connect.AddSessionData(null, videoURL);
                string appendedString = "";
                foreach(string key in sessionData.Keys)
                {
                    appendedString += string.Format("{0}={1}&", key, sessionData[key]);
                }
                videoURL = string.Format("{0}?{1}", videoURL, appendedString);
                AVPlayer player = new AVPlayer(new Foundation.NSUrl(videoURL));
                this.Player = player;
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(this, true, null);
                DismissingNow += () => {
                    tcs.TrySetResult(0);
                };
                this.Player.Play();
            }
            catch (Exception ex)
            {
                tcs.TrySetException(ex);
            }
            await tcs.Task;
        }
    }
}

