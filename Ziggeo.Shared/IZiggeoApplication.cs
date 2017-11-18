using System;
namespace Ziggeo
{
    public interface IZiggeoApplication
    {
        string Token
        {
            get;
        }

        ZiggeoConfig Config
        {
            get;
        }

        ZiggeoConnect Connection
        {
            get;
        }

        ZiggeoVideos Videos
        {
            get;
        }
    }
}
