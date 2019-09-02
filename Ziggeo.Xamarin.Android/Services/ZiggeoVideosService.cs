using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net;
using Com.Ziggeo.Androidsdk.Net.Exceptions;
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
            Videos = ziggeo.Videos();
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

        private readonly IZiggeo _ziggeoInstance;
        private IVideosService Videos { get; }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JArray>();
            Videos.Index(data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JArray.Parse(response.Body().String()));
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<JObject> Get(string tokenOrKey)
        {
            var source = new TaskCompletionSource<JObject>();
            Videos.Get(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JObject.Parse(response.Body().String()));
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<Stream> DownloadVideo(string tokenOrKey)
        {
            var source = new TaskCompletionSource<Stream>();
            Videos.DownloadVideo(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(response.Body().ByteStream());
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<Stream> DownloadImage(string tokenOrKey)
        {
            var source = new TaskCompletionSource<Stream>();
            Videos.DownloadImage(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(response.Body().ByteStream());
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            Videos.ApplyEffect(tokenOrKey, data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JObject.Parse(response.Body().String()));
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            Videos.Update(tokenOrKey, data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JObject.Parse(response.Body().String()));
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task Destroy(string tokenOrKey)
        {
            var source = new TaskCompletionSource<string>();
            Videos.Destroy(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(response.Body().String());
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            await source.Task;
        }

        public async Task<JObject> Create(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            Videos.Create(data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JObject.Parse(response.Body().String()));
                    }
                    else
                    {
                        source.TrySetException(new ResponseException(response.Code(), response.Message()));
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));
            return await source.Task;
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            Videos.Create(new File(filePath), data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        source.TrySetResult(JObject.Parse(response.Body().String()));
                    }
                    else
                    {
                        var ex = new ResponseException(response.Code(), response.Message());
                        source.TrySetException(ex);
                    }
                },
                (call, exception) => { source.TrySetException(exception); }));

            return await source.Task;
        }

        public Uri GetVideoUrl(string tokenOrKey)
        {
            return new Uri(ZUrlHelper.PrepareDownloadVideoUrl(_ziggeoInstance.AppToken, tokenOrKey).Build().ToString());
        }
    }
}