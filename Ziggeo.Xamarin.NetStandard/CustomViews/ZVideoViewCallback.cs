using System;
using System.Collections.Generic;

namespace Ziggeo.Xamarin.NetStandard.CustomViews
{
    public class ZVideoViewCallback
    {
        private IZVideoView ZVideoView { get; set; }

        public ZVideoViewCallback(IZVideoView videoView)
        {
            ZVideoView = videoView;
        }

        public Action<IZVideoView, List<string>> SetVideoUris { get; set; }
        public Action<IZVideoView, List<string>> SetVideoToken = null;
        public Action<IZVideoView> OnPaused = null;
        public Action<IZVideoView> OnResumed = null;
        public Action<IZVideoView> LoadConfigs = null;
        public Action<IZVideoView> InitViews = null;
        public Action<IZVideoView> PrepareQueueAndStartPlaying = null;
        public Action<IZVideoView> StartView = null;

        public void SetVideoPaths(IZVideoView view, List<string> videoPath)
        {
            SetVideoUris?.Invoke(view, videoPath);
            ZVideoView.SetVideoUris (videoPath);
        }

        public void SetVideoTokens(IZVideoView view, List<string> videoTokens)
        {
            SetVideoToken?.Invoke(view, videoTokens);
            ZVideoView.SetVideoTokens(videoTokens);
        }

        public void OnPlayerPaused(IZVideoView view)
        {
            OnPaused?.Invoke(view);
            ZVideoView.OnPause();
        }

        public void OnPlayerResumed(IZVideoView view)
        {
            OnResumed?.Invoke(view);
            ZVideoView.OnResume();
        }

        public void LoadPlayerConfigs(IZVideoView activity)
        {
            LoadConfigs?.Invoke(activity);
            ZVideoView.LoadConfigs();
        }

        public void InitPlayerViews(IZVideoView activity)
        {
            InitViews?.Invoke(activity);
            ZVideoView.InitViews();
        }

        public void PrepareAndStartPlaying(IZVideoView activity)
        {
            PrepareQueueAndStartPlaying?.Invoke(activity);
            ZVideoView.PrepareQueueAndStartPlaying();
        }

        public void StartPlayerView(IZVideoView activity)
        {
            StartView?.Invoke(activity);
        }
    }
}