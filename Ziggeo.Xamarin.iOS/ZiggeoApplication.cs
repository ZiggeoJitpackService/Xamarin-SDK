using System;
using Ziggeo.Services;
using AVFoundation;

namespace Ziggeo
{
    public class ZiggeoApplication : IZiggeoApplication
    {
        public ZiggeoApplication(string token)
        {
            this.Token = token;
            Connect = new ZiggeoConnectImpl(token);
            this.Streams = new ZiggeoStreamsService(Connect);
            this.Videos = new ZiggeoVideosService(Connect, Streams);

            this.Recorder = new Recorder(this);
            this.Player = new Player(this, Connect);

            AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.PlayAndRecord, AVAudioSessionCategoryOptions.DuckOthers | AVAudioSessionCategoryOptions.DefaultToSpeaker);
        }

        public string Token { get; private set; }

        public ZiggeoConnect Connect { get; set; }

        public IZiggeoVideos Videos { get; private set; }

        public IZiggeoStreams Streams { get; private set; }

        public IZiggeoPlayer Player { get; }

        public IZiggeoRecorder Recorder { get; }

        public string ServerAuthToken
        {
            get => Connect.ServerAuthToken;
            set => Connect.ServerAuthToken = value;
        }

        public string ClientAuthToken 
        { 
            get => Connect.ClientAuthToken; 
            set => Connect.ClientAuthToken = value; 
        }
    }
}