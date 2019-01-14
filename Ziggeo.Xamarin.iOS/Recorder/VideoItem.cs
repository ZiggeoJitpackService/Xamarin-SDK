using System;
using UIKit;
using Foundation;

namespace Ziggeo
{
    public class VideoItem
    {
        public VideoItem(NSUrl filePath)
        {
            this.FilePath = filePath;
        }

        public NSUrl FilePath
        {
            get;
            private set;
        }

        public UIImage Cover
        {
            get;
            set;
        }
    }
}
