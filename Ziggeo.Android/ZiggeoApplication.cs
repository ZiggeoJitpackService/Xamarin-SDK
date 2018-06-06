using System;
using Android.Content;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        public ZiggeoApplication(string token)
        {
            this.Token = token;
            Context context = Android.App.Application.Context;
            this.Videos = new ZiggeoVideosService(token, context);
            this.Streams = new ZiggeoStreamsService(token, context);
        }

        public string Token { get; private set; }

        public IZiggeoVideos Videos { get; private set; }

        public IZiggeoStreams Streams { get; private set; }
    }
}