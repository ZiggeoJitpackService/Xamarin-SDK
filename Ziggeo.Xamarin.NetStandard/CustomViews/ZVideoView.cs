using System;
using System.Collections.Generic;

namespace Ziggeo.Xamarin.NetStandard.CustomViews
{
    public interface IZVideoView
    {
         void OnResume();

         void OnPause();

         void InitViews();

         void PrepareQueueAndStartPlaying();

         void SetVideoTokens(List<string> videoToken);

         void SetVideoUris(List<string> videoPath);

         void LoadConfigs();
    }
}