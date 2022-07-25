
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Net;
using Android.Util;
using Android.Views;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZVideoView : View, IZVideoView
    {
        private Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView _videoView;

        public ZVideoView(Context context) : base(context)
        {
            _videoView = new Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView(context: context, attrs: null);
        }

        public ZVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            _videoView = new Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView(context: context, attrs: attrs, defStyleAttr:0);
        }

        public ZVideoView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            _videoView = new Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView(context: context, attrs: attrs, defStyleAttr: defStyleAttr);
        }

        public void OnResume()
        {
            _videoView.OnResume();
        }

        public void OnPause()
        {
            _videoView.OnPause();
        }

        public void InitViews()
        {
            _videoView.InitViews();
        }

        public void PrepareQueueAndStartPlaying()
        {
            _videoView.PrepareQueueAndStartPlaying();
        }

        public void SetVideoTokens(List<string> videoToken)
        {
            _videoView.VideoTokens = videoToken;
        }

        public void SetVideoUris(List<string> videoPath)
        {
            IList<Uri> videoUris = videoPath.Select(Uri.Parse).ToList();
            _videoView.VideoUris = videoUris;
        }

        public void LoadConfigs()
        {
            _videoView.LoadConfigs();
        }
    }
}