using System;
namespace Ziggeo
{
    public class Config
    {
        public Config(string token)
        {
            InitWithToken(token);
        }

        private void InitWithToken(string token)
        {
            if (token.StartsWith("r1", StringComparison.InvariantCultureIgnoreCase))
            {
                ServerApiURL = "https://embed-eu-west-1.ziggeo.com";
                CDNApiURL = "https://embed-cdn-eu-west-1.ziggeo.com";
            }
            else
            {
                ServerApiURL = "https://embed.ziggeo.com";
                CDNApiURL = "https://embed-cdn.ziggeo.com";
            }
        }

        public string ServerApiURL
        {
            get;
            private set;
        }

        public string CDNApiURL
        {
            get;
            private set;
        }
    }
}
