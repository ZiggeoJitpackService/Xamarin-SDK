using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Net;
using Android.Util;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZVideoView : Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView, IZVideoView
    {
        private List<string> _videoToken;
        private List<Uri> _videoPath;
        public ZVideoViewCallback ZCallback;

        public ZVideoView(Context context) : base(context)
        {
        }

        public ZVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public ZVideoView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public void SetVideoTokens(List<string> videoToken)
        {
            base.VideoTokens = videoToken;
            _videoToken = videoToken;
        }

        public void SetVideoUris(List<string> videoPath)
        {
            var videoUris = videoPath.Select(Uri.Parse).ToList();
            base.VideoUris = videoUris;
            _videoPath = videoUris;
        }

        public void StartView()
        {
            base.LoadConfigs();
            base.InitViews();
            if (_videoToken != null)
            {
                base.VideoTokens = _videoToken;
            }

            if (_videoPath != null)
            {
                base.VideoUris = _videoPath;
            }

            base.PrepareQueueAndStartPlaying();
        }
    }
}