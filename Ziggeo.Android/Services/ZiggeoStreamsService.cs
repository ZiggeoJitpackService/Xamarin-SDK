using System;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Rest.Services.Streams;
using Newtonsoft.Json.Linq;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    public class ZiggeoStreamsService : IZiggeoStreams
    {
        public ZiggeoStreamsService(IZiggeo ziggeo)
        {
            _streamsSync = new ZiggeoStreamsServiceSync(ziggeo);
        }

        private readonly ZiggeoStreamsServiceSync _streamsSync;

        public async Task<JObject> Create(string tokenOrKey)
        {
            return await Task<JObject>.Factory.StartNew(() => _streamsSync.Create(tokenOrKey));
        }

        public async Task AttachImage(string tokenOrKey, string streamToken, string filePath)
        {
            await Task.Factory.StartNew(() => _streamsSync.AttachImage(tokenOrKey, streamToken, filePath));
        }

        public async Task<JObject> Bind(string tokenOrKey, string streamToken)
        {
            return await Task<JObject>.Factory.StartNew(() => _streamsSync.Bind(tokenOrKey, streamToken));
        }

        public async Task AttachVideo(string tokenOrKey, string streamToken, string filePath)
        {
            await Task.Factory.StartNew(() => _streamsSync.AttachVideo(tokenOrKey, streamToken, filePath));
        }
    }
}