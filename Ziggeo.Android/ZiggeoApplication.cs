using System;
using Android.Content;
using Com.Ziggeo.Androidsdk;
using Ziggeo.Services;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        public ZiggeoApplication(string token)
        {
            this.Token = token;
            this.Ziggeo = new Com.Ziggeo.Androidsdk.Ziggeo(token, Android.App.Application.Context);
            this.Videos = new ZiggeoVideosService(Ziggeo);
            this.Streams = new ZiggeoStreamsService(Ziggeo);
        }

        public string Token { get; private set; }
        public IZiggeo Ziggeo { get; private set; }

        public IZiggeoVideos Videos { get; private set; }

        public IZiggeoStreams Streams { get; private set; }
    }
}