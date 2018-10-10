using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo.Services
{
    public class ZiggeoStreamsService : BaseService, IZiggeoStreams
    {
        public ZiggeoStreamsService(ZiggeoConnect connection) : base(connection)
        {
        }

        public async Task<JObject> Create(string tokenOrKey)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST,
                string.Format("/videos/{0}/streams?create_stream=true", tokenOrKey), null);
        }

        public async Task AttachImage(string tokenOrKey, string streamToken, string filePath)
        {
            await Connection.RequestData(ZiggeoConnect.Method.POST, string.Format("/videos/{0}/streams/{1}/imageattach", tokenOrKey, streamToken), "image/jpeg", System.IO.File.ReadAllBytes(filePath));
        }
    
        public async Task<JObject> Bind(string tokenOrKey, string streamToken)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST,
                string.Format("/videos/{0}/streams/{1}/recordersubmit", tokenOrKey, streamToken), null);
        }

        public async Task AttachVideo(string tokenOrKey, string streamToken, string file)
        {
            await Connection.BackgroundUpload(
                string.Format("/videos/{0}/streams/{1}/videoattach", tokenOrKey, streamToken),
                "video.mp4",
                tokenOrKey, file);
        }
    }
}