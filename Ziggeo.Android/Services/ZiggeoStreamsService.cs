using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;
using Android.Content;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Rest.Services.Streams;
using Java.IO;
using File = Java.IO.File;

namespace Ziggeo
{
    public class ZiggeoStreamsService : IZiggeoStreams
    {
        public ZiggeoStreamsService(IZiggeo ziggeo)
        {
            Streams = ziggeo.Streams();
        }

        public IStreamsService Streams { get; private set; }

        public async Task<JObject> Create(string tokenOrKey)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Streams.Create(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task<JObject>.Factory.StartNew(() => new JObject(response.Body().String()));
                    }
                    else
                    {
                        task = Task<JObject>.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<JObject>.Factory.StartNew(() => throw exception); }
            ));
            return await task;
        }

        public async Task AttachImage(string tokenOrKey, string streamToken, string filePath)
        {
            var task = Task.Factory.StartNew(() => { });

            Streams.AttachImage(tokenOrKey, streamToken, new File(filePath), new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task.Factory.StartNew(() => { });
                    }
                    else
                    {
                        task = Task.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task.Factory.StartNew(() => throw exception); }
            ));
            await task;
        }

        public async Task<JObject> Bind(string tokenOrKey, string streamToken)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Streams.Bind(tokenOrKey, streamToken, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task<JObject>.Factory.StartNew(() => new JObject(response.Body().String()));
                    }
                    else
                    {
                        task = Task<JObject>.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<JObject>.Factory.StartNew(() => throw exception); }
            ));
            return await task;
        }

        public async Task AttachVideo(string tokenOrKey, string streamToken, string filePath)
        {
            var task = Task.Factory.StartNew(() => { });

            Streams.AttachVideo(tokenOrKey, streamToken, new File(filePath), new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task.Factory.StartNew(() => { });
                    }
                    else
                    {
                        task = Task.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<JObject>.Factory.StartNew(() => throw exception); }
            ));
            await task;
        }
    }
}