using System;
using System.Threading;
using System.Threading.Tasks;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Net.Rest.Services.Streams;
using Newtonsoft.Json.Linq;
using File = Java.IO.File;

namespace Ziggeo.Services
{
    public class ZiggeoStreamsServiceSync
    {
        public ZiggeoStreamsServiceSync(IZiggeo ziggeo)
        {
            Streams = ziggeo.Streams();
        }

        public IStreamsService Streams { get; private set; }

        public JObject Create(string tokenOrKey)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Streams.Create(tokenOrKey, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                    }
                    else
                    {
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) => throw exception));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public void AttachImage(string tokenOrKey, string streamToken, string filePath)
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            Streams.AttachImage(tokenOrKey, streamToken, new File(filePath), new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        autoResetEvent.Set();
                    }
                    else
                    {
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) => throw exception));
            autoResetEvent.WaitOne();
        }

        public JObject Bind(string tokenOrKey, string streamToken)
        {
            JObject jobj = null;
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            Streams.Bind(tokenOrKey, streamToken, new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        jobj = JObject.Parse(response.Body().String());
                    }
                    else
                    {
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) => throw exception));
            autoResetEvent.WaitOne();
            return jobj;
        }

        public void AttachVideo(string tokenOrKey, string streamToken, string filePath)
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);

            Streams.AttachVideo(tokenOrKey, streamToken, new File(filePath), new Callback(
                (call, response) =>
                {
                    if (response.IsSuccessful)
                    {
                        autoResetEvent.Set();
                    }
                    else
                    {
                        throw new Exception(response.Message());
                    }
                },
                (call, exception) => throw exception));
            autoResetEvent.WaitOne();
        }
    }
}