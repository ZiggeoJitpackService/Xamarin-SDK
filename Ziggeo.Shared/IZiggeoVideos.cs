using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public interface IZiggeoVideos
    {
        Task<JArray> Index(Dictionary<string, string> data);

        Task<JObject> Get(string tokenOrKey);

        Task<System.IO.Stream> DownloadVideo(string tokenOrKey);

        Uri GetVideoUrl(string tokenOrKey);

        Task<System.IO.Stream> DownloadImage(string tokenOrKey);

        Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data);

        Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data);

        Task Destroy(string tokenOrKey);

        Task<JObject> Create(Dictionary<string, string> data);

        Task<JObject> Create(string filePath, Dictionary<string, string> data);
    }
}