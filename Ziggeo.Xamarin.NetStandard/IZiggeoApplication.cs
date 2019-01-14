using System;

namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string Token { get; }

        string ServerAuthToken { get; set; }

        string ClientAuthToken { get; set; }

        IZiggeoVideos Videos { get; }

        IZiggeoStreams Streams { get; }

        IZiggeoPlayer Player { get; }

        IZiggeoRecorder Recorder { get; }

    }
}