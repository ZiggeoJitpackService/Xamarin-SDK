using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net;
using Com.Ziggeo.Androidsdk.Net.Models.Auth;
using Com.Ziggeo.Androidsdk.Net.Services.Videos;
using IO.Reactivex.Internal.Functions;
using Newtonsoft.Json.Linq;
using Ziggeo.Services.NativeDelegates;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    public class ZiggeoVideosService : IZiggeoVideos
    {
        public event VideoFileDelegate UploadStarted;
        public event VideoTokenFileProgressDelegate UploadProgressChanged;
        public event VideoTokenFileDelegate UploadComplete;
        public event VideoFileErrorDelegate UploadFailed;

        public ZiggeoVideosService(IZiggeo ziggeo)
        {
            _videosSync = new ZiggeoVideosServiceSync(ziggeo);
            _ziggeoInstance = ziggeo;
            ((VideosService) ziggeo.Videos()).UploadStartedDelegate =
                new NVideoFileDelegate(fileName => UploadStarted?.Invoke(fileName));
            ((VideosService) ziggeo.Videos()).UploadCompleteDelegate =
                new NVideoNVideoTokenFileDelegate((token, fileName) => UploadComplete?.Invoke(token, fileName));
            ((VideosService) ziggeo.Videos()).UploadFailedDelegate =
                new NVideoFileErrorDelegate((fileName, exception) => UploadFailed?.Invoke(fileName, exception));
            ((VideosService) ziggeo.Videos()).UploadProgressChangedDelegate =
                new NVideoTokenFileProgressDelegate((token, fileName, sent, total) =>
                    UploadProgressChanged?.Invoke(token, fileName, sent, total));
        }

        private readonly ZiggeoVideosServiceSync _videosSync;
        private readonly IZiggeo _ziggeoInstance;

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            return await Task<JArray>.Factory.StartNew(() => _videosSync.Index(data));
        }

        public async Task<JObject> Get(string tokenOrKey)
        {
            return await Task<JObject>.Factory.StartNew(() => _videosSync.Get(tokenOrKey));
        }

        public async Task<Stream> DownloadVideo(string tokenOrKey)
        {
            return await Task<Stream>.Factory.StartNew(() => _videosSync.DownloadVideo(tokenOrKey));
        }

        public async Task<Stream> DownloadImage(string tokenOrKey)
        {
            return await Task<Stream>.Factory.StartNew(() => _videosSync.DownloadImage(tokenOrKey));
        }

        public async Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data)
        {
            return await Task<JObject>.Factory.StartNew(() => _videosSync.ApplyEffect(tokenOrKey, data));
        }

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            return await Task<JObject>.Factory.StartNew(() => _videosSync.Update(tokenOrKey, data));
        }

        public async Task Destroy(string tokenOrKey)
        {
            await Task<string>.Factory.StartNew(() => _videosSync.Destroy(tokenOrKey));
        }

        public async Task<JObject> Create(Dictionary<string, string> data)
        {
            return await Task<JObject>.Factory.StartNew(() => _videosSync.Create(data));
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            try
            {
                UploadStarted?.Invoke(filePath);
                var result = await Task<JObject>.Factory.StartNew(() => _videosSync.Create(filePath, data));
                string videoToken = result["video"]["token"].Value<string>();
                UploadComplete?.Invoke(videoToken, filePath);
                return result;
            }
            catch (Exception ex)
            {
                UploadFailed?.Invoke(filePath, ex);
                throw ex;
            }
        }

        public Uri GetVideoUrl(string tokenOrKey)
        {
            return new Uri(ZUrlHelper.PrepareDownloadVideoUrl(_ziggeoInstance.AppToken, tokenOrKey).Build().ToString());
        }
    }
}