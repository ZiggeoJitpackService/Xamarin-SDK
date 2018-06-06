using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Ziggeo
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
            throw new NotImplementedException();
            // TODO change this method to accept filePath as arg
            //            await Connection.RequestData(ZiggeoConnect.Method.POST,
            //                string.Format("/videos/{0}/streams/{1}/imageattach", tokenOrKey, streamToken), "image/jpeg",
            //                filePath);
        }

        public async Task<JObject> Bind(string tokenOrKey, string streamToken)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST,
                string.Format("/videos/{0}/streams/{1}/recordersubmit", tokenOrKey, streamToken), null);
        }

        public async Task AttachVideo(string tokenOrKey, string streamToken, string file)
        {
            throw new NotImplementedException();
//            return await Connection.BackgroundUpload(
//                string.Format("/videos/{0}/streams/{1}/videoattach", tokenOrKey, streamToken),
//                "video.mp4",
//                string.Format("/videos/{0}/streams/{1}/recordersubmit", tokenOrKey, streamToken), file);
        }
    }
}