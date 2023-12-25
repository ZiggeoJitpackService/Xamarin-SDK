using System;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Exceptions;
using Com.Ziggeo.Androidsdk.Net.Services.Streams;
using Newtonsoft.Json.Linq;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    public class ZiggeoStreamsService : IStreams
    {
        public ZiggeoStreamsService(IZiggeo ziggeo)
        {
            Streams = ziggeo.Streams();
        }

        private IStreamsService Streams { get; }

        public async Task<JObject> Create(string tokenOrKey)
        {
            var source = new TaskCompletionSource<JObject>();
            Streams.Create(tokenOrKey, new Callback(
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

        public async Task AttachImage(string tokenOrKey, string streamToken, string filePath)
        {
            var source = new TaskCompletionSource<string>();
            Streams.AttachImage(tokenOrKey, streamToken, new File(filePath), new Callback(
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

        public async Task<JObject> Bind(string tokenOrKey, string streamToken, string uploadId)
        {
            var source = new TaskCompletionSource<JObject>();
            Streams.Bind(tokenOrKey, streamToken, null, uploadId,new Callback(
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

        public async Task AttachVideo(string tokenOrKey, string streamToken, string filePath)
        {
            var source = new TaskCompletionSource<string>();
            Streams.AttachVideo(tokenOrKey, streamToken, new File(filePath), new Callback(
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
    }
}