using System.Collections.Generic;
using Android.Content;
using Android.Net;
using Android.Util;
using Com.Ziggeo.Androidsdk.Callbacks;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZVideoView : Com.Ziggeo.Androidsdk.Widgets.Videoview.ZVideoView
    {
        public ZVideoView(Context context) : base(context)
        {
        }

        public ZVideoView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public ZVideoView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public void OnResume()
        {
            base.OnResume();
        }

        public void OnPause()
        {
            base.OnPause();
        }

        public void InitViews()
        {
            base.InitViews();
        }

        public void PrepareQueueAndStartPlaying()
        {
            base.PrepareQueueAndStartPlaying();
        }

        public void SetVideoTokens(List<string> videoToken)
        {
            base.VideoTokens = videoToken;
        }

        public void SetVideoUris(List<Uri> videoPath)
        {
            base.VideoUris = videoPath;
        }

        public void LoadConfigs()
        {
            base.LoadConfigs();
        }
    }
}