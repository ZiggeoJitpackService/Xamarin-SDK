using System;
namespace Ziggeo
{
    public class ZiggeoApplicationBase
    {
        protected ZiggeoApplicationBase(string token)
        {
            this.Token = token;
        }

        public string Token
        {
            get;
            protected set;
        }

        public ZiggeoConfig Config
        {
            get;
            protected set;
        }

        public ZiggeoConnect Connection
        {
            get;
            protected set;
        }

        public ZiggeoVideos Videos
        {
            get;
            protected set;
        }
    }
}
