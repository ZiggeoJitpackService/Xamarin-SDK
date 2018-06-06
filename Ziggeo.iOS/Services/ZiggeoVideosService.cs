using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo.Services
{
    public class ZiggeoVideosService : BaseService, IZiggeoVideos
    {
        public ZiggeoVideosService(ZiggeoConnect connection) : base(connection)
        {
        }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            return await Connection.RequestJSONArray(ZiggeoConnect.Method.GET, "/videos/", data);
        }

        public async Task<JObject> Get(string tokenOrKey)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.GET, "/videos/" + tokenOrKey + "",
                null);
        }

        public async Task<Stream> DownloadVideo(string tokenOrKey)
        {
            //TODO
            throw new NotImplementedException();
            // return await Connection.GetServerURL("/videos/" + tokenOrKey + "/video.mp4");
        }

        public async Task<Stream> DownloadImage(string tokenOrKey)
        {

            //TODO
            throw new NotImplementedException();
//            return await Connection.RequestData(ZiggeoConnect.Method.GET,
//                "/videos/" + tokenOrKey + "/image", null);
        }

        public async Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST,
                "/videos/" + tokenOrKey + "/effect", data);
        }

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos/" + tokenOrKey + "",
                data);
        }

        public async Task Destroy(string tokenOrKey)
        {
            await Connection.RequestString(ZiggeoConnect.Method.DELETE, "/videos/" + tokenOrKey + "",
                null);
        }

        public async Task<JObject> Create(Dictionary<string, string> data)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos?create_stream=true",
                data);
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            Console.WriteLine("creating video...");
            var video = await Create(data);
            string videoToken = video["video"]["token"].Value<string>();
            Console.WriteLine("video token = {0}", videoToken);
            string streamToken = video["stream"]["token"].Value<string>();
            Console.WriteLine("stream token = {0}", streamToken);
            await AttachVideo(videoToken, streamToken, filePath);
            Console.WriteLine("video attached");
            return await Submit(videoToken, streamToken);
        }

        // TODO four methods below should be removed when Create method with file will be reimplemented
        public async Task<JObject> CreateStream(string tokenOrKey)
        {
            return await Connection.RequestJSON(ZiggeoConnect.Method.POST,
                string.Format("/videos/{0}/streams?create_stream=true", tokenOrKey), null);
        }

        public async Task<JObject> Submit(string tokenOrKey, string streamToken)
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