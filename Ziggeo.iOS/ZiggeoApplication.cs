using System;
using Ziggeo.Services;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        public ZiggeoApplication(string token)
        {
            this.Token = token;
            ZiggeoConnect connect = new ZiggeoConnectImpl(token);
            this.Videos = new ZiggeoVideosService(connect);
            this.Streams = new ZiggeoStreamsService(connect);
        }

        public string Token { get; private set; }

        public IZiggeoVideos Videos { get; private set; }

        public IZiggeoStreams Streams { get; private set; }
    }
}