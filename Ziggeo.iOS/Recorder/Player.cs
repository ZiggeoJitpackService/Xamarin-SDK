using System;

using UIKit;
using AVFoundation;
using AVKit;
using System.Threading.Tasks;

namespace Ziggeo
{
    public partial class Player : AVPlayerViewController, IZiggeoPlayer
    {
        delegate void PlayerDelegate();
        event PlayerDelegate DismissingNow = null;

        public Player(IZiggeoApplication application) : base("Player", null)
        {
            this.Application = application;
        }

        public IZiggeoApplication Application
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

        public Task Play(string videoToken)
        {
            TaskCompletionSource<int> tcs = new TaskCompletionSource<int>();
            try
            {
                AVPlayer player = new AVPlayer(new Foundation.NSUrl(Application.Videos.GetVideoURL(videoToken)));
                this.Player = player;
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(this, true, null);
                DismissingNow += () => {
                    tcs.SetResult(0);
                };
                this.Player.Play();
            }
            catch(Exception ex)
            {
                tcs.TrySetException(ex);
            }
            return tcs.Task;
        }
    }
}

