using System;
namespace Ziggeo
{
    public class ZiggeoApplication
    {
        public ZiggeoApplication(string token)
        {
            this.Token = token;
            this.Config = new ZiggeoConfig(Token);
            //this.Connection = new ZiggeoConnect(this);
            this.Videos = new ZiggeoVideos(this);
        }

        public string Token
        {
            get;
            private set;
        }

        public ZiggeoConfig Config
        {
            get;
            private set;
        }

        public ZiggeoConnect Connection
        {
            get;
            private set;
        }

        public ZiggeoVideos Videos
        {
            get;
            private set;
        }
    }
}
