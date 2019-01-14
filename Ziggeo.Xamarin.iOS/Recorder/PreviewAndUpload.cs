using System;
using AVFoundation;
using Foundation;
using UIKit;
using CoreFoundation;

namespace Ziggeo
{
    public partial class PreviewAndUpload : VideoProcessor
    {
        public PreviewAndUpload(VideoItem item) : base("PreviewAndUpload", null, item)
        {
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

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            InitPlayer();
        }

        private AVPlayer Player
        {
            get;
            set;
        }

        private AVPlayerLayer PlayerLayer
        {
            get;
            set;
        }

        private NSObject PlayerObserver
        {
            get;
            set;
        }

        public bool Playing
        {
            get;
            private set;
        }

        private void KillPlayer()
        {
            if(Player != null)
            {
                Player.Pause();
                if(PlayerObserver != null) NSNotificationCenter.DefaultCenter.RemoveObserver(PlayerObserver);
                PlayerLayer?.RemoveFromSuperLayer();
                Player = null;
                PlayerLayer = null;
                Playing = false;
                playPauseButton.SetImage(ImageLoader.GetImageFromResource("Play-50"), UIControlState.Normal);
            }
        }

        private void InitPlayer()
        {
            if(VideoItem != null && VideoItem.FilePath != null && IsViewLoaded)
            {
                KillPlayer();
                AVPlayerItem playerItem = new AVPlayerItem(VideoItem.FilePath);
                PlayerObserver = NSNotificationCenter.DefaultCenter.AddObserver(AVPlayerItem.DidPlayToEndTimeNotification, (obj) => { DidFinishPlaying(); }, playerItem);

                Player = new AVPlayer(playerItem);
                PlayerLayer = AVPlayerLayer.FromPlayer(Player);
                PlayerLayer.Frame = VideoPlaceholder.Frame;
                VideoPlaceholder.Layer.AddSublayer(PlayerLayer);
                Playing = false;
            }
        }

        private void DidFinishPlaying()
        {
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                playPauseButton.SetImage(ImageLoader.GetImageFromResource("Play-50"), UIControlState.Normal);
                Player?.Pause();
                Player?.Seek(new CoreMedia.CMTime(0, 1));
                Console.WriteLine("playback finished");
            });
        }

        private void Upload()
        {
        }

        partial void CancelButton_TouchUpInside(UIButton sender)
        {
            base.DismissAndSignalItsCanceled();
        }

        partial void UploadButton_TouchUpInside(UIButton sender)
        {
            if (NextProcessor == null)
            {
                base.DismissAndSignalItsDone();
                Upload();
            }
            else
            {
                NextProcessor.Done += (VideoProcessor processor) => {
                    base.DismissAndSignalItsDone();
                    Upload();
                };
                NextProcessor.Canceled += (VideoProcessor processor) => {                    
                    base.DismissAndSignalItsDone();
                    Upload();
                };
                PresentViewController(NextProcessor, true, null);    
            }
        }

        partial void PlayPauseButton_TouchUpInside(UIButton sender)
        {
            if(Player != null)
            {
                if (Playing) Player.Pause();
                else Player.Play();
                Playing = !Playing;
                playPauseButton.SetImage(ImageLoader.GetImageFromResource(Playing ? "Pause-50" : "Play-50"), UIControlState.Normal);
            }
        }
    }
}

