using System;
using UIKit;
using Foundation;
using CoreFoundation;

namespace Ziggeo
{

    public abstract class VideoProcessor : UIViewController
    {
        public delegate void VideoProcessorDelegate(VideoProcessor processor);
        public event VideoProcessorDelegate Done = null;
        public event VideoProcessorDelegate Canceled = null;

        public VideoProcessor(string nibName, NSBundle bundle, VideoItem item): base(nibName, bundle)
        {
            this.VideoItem = item;
        }

        public VideoItem VideoItem
        {
            get;
            private set;
        }

        public VideoProcessor NextProcessor
        {
            get;
            set;
        }

        protected void DismissAndSignalItsDone(bool animated = false)
        {
            DispatchQueue.MainQueue.DispatchAsync(() => this.DismissViewController(animated, () => Done?.Invoke(this)));
        }

        protected void DismissAndSignalItsCanceled(bool animated = true)
        {
            DispatchQueue.MainQueue.DispatchAsync(() => this.DismissViewController(animated, () => Canceled?.Invoke(this)));
        }
    }
}
