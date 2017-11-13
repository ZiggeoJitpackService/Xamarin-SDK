using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Ziggeo
{
    public class ZiggeoVideos
    {
        public ZiggeoVideos(ZiggeoApplication application)
        {
            this.Application = application;
        }

        protected ZiggeoApplication Application
        {
            get;
            private set;
        }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            return await Application.Connection.RequestJSONArray(ZiggeoConnect.Method.GET, "/videos/", data);
        }

        public async Task<JObject> Get(string token_or_key)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.GET, "/videos/" + token_or_key + "", null);
        }

        public string GetVideoURL(string token_or_key)
        {
            return Application.Connection.GetServerURL("/videos/" + token_or_key + "/video.mp4");
        }

        public async Task<byte[]> GetCover(string token_or_key)
        {
            return await Application.Connection.RequestData(ZiggeoConnect.Method.GET, "/videos/" + token_or_key + "/image", null);
        }

        public async Task<JObject> PushToService(string token_or_key, Dictionary<string, string> data)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos/" + token_or_key + "/push", data);
        }

        public async Task<JObject> ApplyEffect(string token_or_key, Dictionary<string, string> data)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos/" + token_or_key + "/effect", data);
        }

        public async Task<JObject> Update(string token_or_key, Dictionary<string, string> data)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos/" + token_or_key + "", data);
        }

        public async Task<JObject> Delete(string token_or_key)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.DELETE, "/videos/" + token_or_key + "", null);
        }

        public async Task<JObject> CreateEmptyVideo(Dictionary<string, string> data)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, "/videos?create_stream=true", data);
        }

        public async Task<JObject> CreateStream(string token_or_key)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, string.Format("/videos/{0}/streams?create_stream=true", token_or_key), null);
        }

        public async Task AttachCover(string token_or_key, string stream_token, byte[] jpegData)
        {
            await Application.Connection.RequestData(ZiggeoConnect.Method.POST, string.Format("/videos/{0}/streams/{1}/imageattach", token_or_key, stream_token), "image/jpeg", jpegData);
        }

        public async Task<JObject> Submit(string token_or_key, string stream_token)
        {
            return await Application.Connection.RequestJSON(ZiggeoConnect.Method.POST, string.Format("/videos/{0}/streams/{1}/recordersubmit", token_or_key, stream_token), null);
        }

        public async Task<byte[]> AttachVideo(string token_or_key, string stream_token, string file)
        {
            return await Application.Connection.BackgroundUpload(string.Format("/videos/{0}/streams/{1}/videoattach", token_or_key, stream_token),
                                                                 "video.mp4",
                                                                 string.Format("/videos/{0}/streams/{1}/recordersubmit", token_or_key, stream_token), file);
        }

        public async Task<JObject> UploadVideo(string file, Dictionary<string, string> data)
        {
            Console.WriteLine("creating video...");
            var video = await CreateEmptyVideo(data);
            string videoToken = video["video"]["token"].Value<string>();
            Console.WriteLine("video token = {0}", videoToken);
            string streamToken = video["stream"]["token"].Value<string>();
            Console.WriteLine("stream token = {0}", streamToken);
            await AttachVideo(videoToken, streamToken, file);
            Console.WriteLine("video attached");
            return await Submit(videoToken, streamToken);
        }
    }
}
