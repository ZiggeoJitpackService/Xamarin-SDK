using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Services.Videos;
using Newtonsoft.Json.Linq;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    class ZiggeoVideosServiceSync
    {
        public ZiggeoVideosServiceSync(IZiggeo ziggeo)
        {
            Videos = ziggeo.Videos();
        }

        public IVideosService Videos { get; private set; }

        public JArray Index(Dictionary<string, string> data)
        {
            JArray array = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Index(data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        var respBody = response.Body().String();
                        array = JArray.Parse(respBody);
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return array;
        }

        public JObject Get(string tokenOrKey)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Get(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public Stream DownloadVideo(string tokenOrKey)
        {
            Stream stream = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            Videos.DownloadVideo(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        stream = response.Body().ByteStream();
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return stream;
        }

        public Stream DownloadImage(string tokenOrKey)
        {
            Stream stream = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.DownloadImage(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        stream = response.Body().ByteStream();
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return stream;
        }

        public JObject ApplyEffect(string tokenOrKey, Dictionary<string, string> data)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.ApplyEffect(tokenOrKey, data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public JObject Update(string tokenOrKey, Dictionary<string, string> data)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Update(tokenOrKey, data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public string Destroy(string tokenOrKey)
        {
            string str = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Destroy(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        str = response.Body().String();
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return str;
        }

        public JObject Create(Dictionary<string, string> data)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Create(data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public JObject Create(string filePath, Dictionary<string, string> data)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Videos.Create(new File(filePath), data, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                        autoResetEvent.Set();
                    }
                    else
                    {
                        autoResetEvent.Set();
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) =>
                {
                    autoResetEvent.Set();
                    throw exception;
                }));
            autoResetEvent.WaitOne();
            return jobj;
        }
    }
}