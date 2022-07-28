using System;
using System.Collections.Generic;
using Com.Ziggeo.Androidsdk.Widgets.Videoview;

namespace Ziggeo.Xamarin.NetStandard.CustomViews
{
    public class ZVideoViewCallback
    {
        private IZVideoView ZVideoView { get; set; }

        public ZVideoViewCallback(IZVideoView videoView)
        {
            ZVideoView = videoView;
        }

        public Action<ZVideoView, List<string>> SetVideoUris { get; set; }
        public Action<ZVideoView, List<string>> SetVideoToken = null;
        public Action<ZVideoView> OnPaused = null;
        public Action<ZVideoView> OnResumed = null;
        public Action<ZVideoView> LoadConfigs = null;
        public Action<ZVideoView> InitViews = null;
        public Action<ZVideoView> PrepareQueueAndStartPlaying = null;
        public Action<ZVideoView> StartView = null;

        public void SetVideoPaths(ZVideoView view, List<string> videoPath)
        {
            SetVideoUris?.Invoke(view, videoPath);
            ZVideoView.SetVideoUris (videoPath);
        }

        public void SetVideoTokens(ZVideoView view, List<string> videoTokens)
        {
            SetVideoToken?.Invoke(view, videoTokens);
            ZVideoView.SetVideoTokens(videoTokens);
        }

        public void OnPlayerPaused(ZVideoView view)
        {
            OnPaused?.Invoke(view);
            ZVideoView.OnPause();
        }

        public void OnPlayerResumed(ZVideoView view)
        {
            OnResumed?.Invoke(view);
            ZVideoView.OnResume();
        }

        public void LoadPlayerConfigs(ZVideoView activity)
        {
            LoadConfigs?.Invoke(activity);
            ZVideoView.LoadConfigs();
        }

        public void InitPlayerViews(ZVideoView activity)
        {
            InitViews?.Invoke(activity);
            ZVideoView.InitViews();
        }

        public void PrepareAndStartPlaying(ZVideoView activity)
        {
            PrepareQueueAndStartPlaying?.Invoke(activity);
            ZVideoView.PrepareQueueAndStartPlaying();
        }

        public void StartPlayerView(ZVideoView activity)
        {
            StartView?.Invoke(activity);
        }
    }
}