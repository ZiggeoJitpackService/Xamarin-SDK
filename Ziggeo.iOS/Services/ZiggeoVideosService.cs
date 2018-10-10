using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo.Services
{
    public class ZiggeoVideosService : BaseService, IZiggeoVideos
    {
        public event VideoFileDelegate UploadStarted;
        //public event VideoTokenFileDelegate TokenAssigned;
        public event VideoTokenFileProgressDelegate UploadProgressChanged;
        public event VideoTokenFileDelegate UploadComplete;
        public event VideoFileErrorDelegate UploadFailed;

        public ZiggeoVideosService(ZiggeoConnect connection, IZiggeoStreams streams) : base(connection)
        {
            this.Streams = streams;
            connection.UploadProgressChanged += (string token, string filename, long bytesSent, long totalBytes) => {
                UploadProgressChanged?.Invoke(token, filename, bytesSent, totalBytes);
            };
        }

        public IZiggeoStreams Streams
        {
            get;
            private set;
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
            //not needed in current implementation
            throw new NotImplementedException();
        }

        public async Task<Stream> DownloadImage(string tokenOrKey)
        {
            byte[] data = await Connection.RequestDataAsync(ZiggeoConnect.Method.GET, "/videos/" + tokenOrKey + "/image", null);
            return new System.IO.MemoryStream(data);
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
            try
            {
                UploadStarted?.Invoke(filePath);
                Console.WriteLine("creating video...");
                var video = await Create(data);
                string videoToken = video["video"]["token"].Value<string>();
                Console.WriteLine("video token = {0}", videoToken);
                //TokenAssigned?.Invoke(videoToken, filePath);
                string streamToken = video["stream"]["token"].Value<string>();
                Console.WriteLine("stream token = {0}", streamToken);
                await Streams.AttachVideo(videoToken, streamToken, filePath);
                Console.WriteLine("video attached");
                var result = await Streams.Bind(videoToken, streamToken);
                UploadComplete?.Invoke(videoToken, filePath);
                return result;
            }
            catch(Exception ex)
            {
                UploadFailed?.Invoke(filePath, ex);
                throw ex;
            }
        }

        public Uri GetVideoUrl(string tokenOrKey)
        {
            
            return new Uri(Connection.GetServerURL("/videos/" + tokenOrKey + "/video.mp4"));
        }
    }
}