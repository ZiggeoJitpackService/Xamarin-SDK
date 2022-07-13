using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Exceptions;
using Com.Ziggeo.Androidsdk.Net.Services.Audios;
using Java.IO;
using Newtonsoft.Json.Linq;
using Ziggeo.Services;
using Ziggeo.Services.NativeDelegates;

namespace Ziggeo.Xamarin.Android.Services
{
    public class ZiggeoAudioService : IAudios
    {
        public event VideoFileDelegate UploadStarted;
        public event VideoTokenFileProgressDelegate UploadProgressChanged;
        public event VideoTokenFileDelegate UploadComplete;
        public event VideoFileErrorDelegate UploadFailed;

        public ZiggeoAudioService(IZiggeo ziggeo)
        {
            ziggeo.Audios();
            Audios = ziggeo.Audios();
            _ziggeoInstance = ziggeo;
            ((AudiosService)ziggeo.Audios()).UploadStartedDelegate =
            new NVideoFileDelegate(fileName => UploadStarted?.Invoke(fileName));
            ((AudiosService)ziggeo.Audios()).UploadCompleteDelegate =
            new NVideoNVideoTokenFileDelegate((token, fileName) => UploadComplete?.Invoke(token, fileName));
            ((AudiosService)ziggeo.Audios()).UploadFailedDelegate =
            new NVideoFileErrorDelegate((fileName, exception) => UploadFailed?.Invoke(fileName, exception));
            ((AudiosService)ziggeo.Audios()).UploadProgressChangedDelegate =
            new NVideoTokenFileProgressDelegate((token, fileName, sent, total) =>
            UploadProgressChanged?.Invoke(token, fileName, sent, total));
        }

        private readonly IZiggeo _ziggeoInstance;
        private IAudiosService Audios { get; }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JArray>();
            Audios.Index(data, new Callback(
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
            Audios.Get(tokenOrKey, new Callback(
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
            Audios.Update(tokenOrKey, data, new Callback(
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
            Audios.Destroy(tokenOrKey, new Callback(
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
            Audios.Create(new File(filePath), data, new Callback(
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
    }
}

