using System;
namespace Ziggeo
{
    public class ZiggeoApplication: ZiggeoApplicationBase
    {
        public ZiggeoApplication(string token) : base(token)
        {
            this.Config = new ZiggeoConfig(Token);
            this.Connection = new ZiggeoConnectImpl(this);
            this.Videos = new ZiggeoVideos(this);
        }
    }
}
