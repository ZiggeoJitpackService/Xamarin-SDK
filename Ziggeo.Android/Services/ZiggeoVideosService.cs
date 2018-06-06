using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Rest.Services.Videos;
using Newtonsoft.Json.Linq;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    public class ZiggeoVideosService : IZiggeoVideos
    {
        public ZiggeoVideosService(IZiggeo ziggeo) 
        {
            Videos = ziggeo.Videos();
        }

        public IVideosService Videos { get; private set; }

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            var task = Task<JArray>.Factory.StartNew(() => null);

            Videos.Index(data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task<JArray>.Factory.StartNew(() => new JArray(response.Body().String()));
                    }
                    else
                    {
                        task = Task<JArray>.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<JArray>.Factory.StartNew(() => throw exception); }
            ));
            return await task;
        }

        public async Task<JObject> Get(string tokenOrKey)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Videos.Get(tokenOrKey, new Callback(
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

        public async Task<Stream> DownloadVideo(string tokenOrKey)
        {
            var task = Task<Stream>.Factory.StartNew(() => null);

            Videos.DownloadVideo(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task<Stream>.Factory.StartNew(() => response.Body().ByteStream());
                    }
                    else
                    {
                        task = Task<Stream>.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<Stream>.Factory.StartNew(() => throw exception); }
            ));
            return await task;
        }

        public async Task<System.IO.Stream> DownloadImage(string tokenOrKey)
        {
            var task = Task<Stream>.Factory.StartNew(() => null);

            Videos.DownloadImage(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        task = Task<Stream>.Factory.StartNew(() => response.Body().ByteStream());
                    }
                    else
                    {
                        task = Task<Stream>.Factory.StartNew(() => throw new Exception(response.Message()));
                    }
                },
                (call, exception) => { task = Task<Stream>.Factory.StartNew(() => throw exception); }
            ));
            return await task;
        }

        public async Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Videos.ApplyEffect(tokenOrKey, data, new Callback(
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

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Videos.Update(tokenOrKey, data, new Callback(
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

        public async Task Destroy(string tokenOrKey)
        {
            var task = Task.Factory.StartNew(() => { });

            Videos.Destroy(tokenOrKey, new Callback(
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

        public async Task<JObject> Create(Dictionary<string, string> data)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Videos.Create(data, new Callback(
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

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            var task = Task<JObject>.Factory.StartNew(() => null);

            Videos.Create(new File(filePath), data, new Callback(
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
    }
}