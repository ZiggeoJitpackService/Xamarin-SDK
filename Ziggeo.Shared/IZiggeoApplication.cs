using System;
namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string Token
        {
            get;
        }

        IZiggeoVideos Videos
        {
            get;
        }

        IZiggeoStreams Streams
        {
            get;
        }

    }
}
