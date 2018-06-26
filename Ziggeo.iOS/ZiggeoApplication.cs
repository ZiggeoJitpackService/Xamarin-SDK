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
            this.Streams = new ZiggeoStreamsService(connect);
            this.Videos = new ZiggeoVideosService(connect, Streams);

            this.Recorder = new Recorder(this);
            this.Player = new Player(this);
        }

        public string Token { get; private set; }

        public IZiggeoVideos Videos { get; private set; }

        public IZiggeoStreams Streams { get; private set; }

        public IZiggeoPlayer Player { get; }

        public IZiggeoRecorder Recorder { get; }
    }
}