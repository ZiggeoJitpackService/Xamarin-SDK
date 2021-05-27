using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Exceptions;
using Com.Ziggeo.Androidsdk.Net.Services.Images;
using Java.IO;
using Newtonsoft.Json.Linq;
using Ziggeo.Services;
using Ziggeo.Services.NativeDelegates;

namespace Ziggeo.Xamarin.Android.Services
{
    public class ZiggeoImageService : IImages
    {
        public event VideoFileDelegate UploadStarted;
        public event VideoTokenFileProgressDelegate UploadProgressChanged;
        public event VideoTokenFileDelegate UploadComplete;
        public event VideoFileErrorDelegate UploadFailed;

        public ZiggeoImageService(IZiggeo ziggeo)
        {
            Images = ziggeo.Images();
            _ziggeoInstance = ziggeo;
            ((ImagesService)ziggeo.Images()).UploadStartedDelegate =
            new NVideoFileDelegate(fileName => UploadStarted?.Invoke(fileName));
            ((ImagesService)ziggeo.Images()).UploadCompleteDelegate =
            new NVideoNVideoTokenFileDelegate((token, fileName) => UploadComplete?.Invoke(token, fileName));
            ((ImagesService)ziggeo.Images()).UploadFailedDelegate =
            new NVideoFileErrorDelegate((fileName, exception) => UploadFailed?.Invoke(fileName, exception));
            ((ImagesService)ziggeo.Images()).UploadProgressChangedDelegate =
            new NVideoTokenFileProgressDelegate((token, fileName, sent, total) =>
            UploadProgressChanged?.Invoke(token, fileName, sent, total));
        }

        private readonly IZiggeo _ziggeoInstance;
        private IImagesService Images { get; }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JArray>();
            Images.Index(data, new Callback(
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
            Images.Get(tokenOrKey, new Callback(
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
            Images.Update(tokenOrKey, data, new Callback(
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

        public Task<JObject> Update(string json)
        {
            throw new NotImplementedException();
        }

        public async Task Destroy(string tokenOrKey)
        {
            var source = new TaskCompletionSource<string>();
            Images.Destroy(tokenOrKey, new Callback(
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

        public Task<JObject> Create(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            Images.Create(new File(filePath), data, new Callback(
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

        public Task<JObject> GetImageUrl(string tokenOrKey)
        {
            throw new NotImplementedException();
        }
    }
}

