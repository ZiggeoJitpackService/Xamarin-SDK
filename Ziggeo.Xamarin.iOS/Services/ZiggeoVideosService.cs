using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json.Linq;
using Foundation;
using ZiggeoMediaSDK;

namespace Ziggeo.Xamarin.iOS.Services
{
    public class ZiggeoVideosService : IVideos
    {
        public event VideoFileDelegate UploadStarted;
        public event VideoTokenFileProgressDelegate UploadProgressChanged;
        public event VideoTokenFileDelegate UploadComplete;
        public event VideoFileErrorDelegate UploadFailed;

        private readonly ZiggeoMediaSDK.Ziggeo _ziggeoInstance;
        private ZiggeoVideos Videos { get; }

        public ZiggeoVideosService(ZiggeoMediaSDK.Ziggeo ziggeo)
        {
            Videos = ziggeo.Videos;
            _ziggeoInstance = ziggeo;
        }       

        public async Task<JArray> Index(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JArray>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Videos.Index(dictionary, (jsonArray, error) =>
            {
                if (error == null)
                {
                    var result = new JArray();
                    for (nuint i = 0; i < jsonArray.Count; i++)
                    {
                        var item = jsonArray.GetItem<Video>(i);

                        var tags = new JArray();
                        for (int j = 0; j < item.Tags.Length; j++)
                        {
                            tags.Add(item.Tags[j].ToString());
                        }
                        var jsonObject = new JObject(
                            new JProperty("token", item.Token),
                            new JProperty("state_string", item.StateString),
                            new JProperty("title", item.Title),
                            new JProperty("description", item.Description),
                            new JProperty("submission_date", item.Date.ToString()),
                            new JProperty("tags", tags),
                            new JProperty("key", item.Key),
                            new JProperty("VideoItem", "")
                        );
                        result.Add(jsonObject);
                    }
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });

            return await source.Task;
        }

        public async Task<JObject> Get(string tokenOrKey)
        {
            var source = new TaskCompletionSource<JObject>();
            var dictionary = new NSDictionary();

            Videos.Get(tokenOrKey, dictionary, (item, response, error) =>
            {
                if (error == null)
                {
                    var tags = new JArray();
                    for (int j = 0; j < item.Tags.Length; j++)
                    {
                        tags.Add(item.Tags[j].ToString());
                    }
                    var result = new JObject(
                        new JProperty("token", item.Token),
                        new JProperty("state_string", item.StateString),
                        new JProperty("title", item.Title),
                        new JProperty("description", item.Description),
                        new JProperty("submission_date", item.Date.ToString()),
                        new JProperty("tags", tags),
                        new JProperty("key", item.Key),
                        new JProperty("VideoItem", "")
                    );
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });

            return await source.Task;
        }

        public async Task<String> GetVideoUrl(string tokenOrKey)
        {
            var source = new TaskCompletionSource<String>();
            source.SetResult(Videos.GetVideoUrl(tokenOrKey));
            return await source.Task;
        }

        public async Task<String> GetImageUrl(string tokenOrKey)
        {
            var source = new TaskCompletionSource<String>();
            source.SetResult(Videos.GetImageUrl(tokenOrKey));
            return await source.Task;
        }

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Videos.Update(tokenOrKey, dictionary, (item, response, error) =>
            {
                if (error == null)
                {
                    var tags = new JArray();
                    for (int j = 0; j < item.Tags.Length; j++)
                    {
                        tags.Add(item.Tags[j].ToString());
                    }
                    var result = new JObject(
                        new JProperty("token", item.Token),
                        new JProperty("state_string", item.StateString),
                        new JProperty("title", item.Title),
                        new JProperty("description", item.Description),
                        new JProperty("submission_date", item.Date.ToString()),
                        new JProperty("tags", tags),
                        new JProperty("key", item.Key),
                        new JProperty("VideoItem", "")
                    );
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });

            return await source.Task;
        }

        public async Task Destroy(string tokenOrKey)
        {
            var source = new TaskCompletionSource<string>();

            Videos.Destroy(tokenOrKey, "", (jsonObject, response, error) =>
            {
                if (error == null)
                {
                    var result = "";
                    if (jsonObject != null)
                    {
                        result = jsonObject.ToString();
                    }
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });
            await source.Task;
        }

        public async Task<JObject> Create(Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Videos.CreateEmptyVideoWithData(dictionary, (jsonObject, response, error) =>
            {
                if (error == null)
                {
                    var item = new Video();
                    item.SetInfo(jsonObject);

                    var tags = new JArray();
                    for (int j = 0; j < item.Tags.Length; j++)
                    {
                        tags.Add(item.Tags[j].ToString());
                    }
                    var result = new JObject(
                        new JProperty("token", item.Token),
                        new JProperty("state_string", item.StateString),
                        new JProperty("title", item.Title),
                        new JProperty("description", item.Description),
                        new JProperty("submission_date", item.Date.ToString()),
                        new JProperty("tags", tags),
                        new JProperty("key", item.Key),
                        new JProperty("VideoItem", "")
                    );
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });

            return await source.Task;
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Videos.Create(filePath, dictionary, (jsonObject, response, error) =>
            {
            },
            (totalBytesSent, totalBytesExpectedToSend) =>
            {
            },
            (jsonObject, response, error) =>
            {
                if (error == null)
                {
                    var item = new Video();
                    item.SetInfo(jsonObject);

                    var tags = new JArray();
                    for (int j = 0; j < item.Tags.Length; j++)
                    {
                        tags.Add(item.Tags[j].ToString());
                    }
                    var result = new JObject(
                        new JProperty("token", item.Token),
                        new JProperty("state_string", item.StateString),
                        new JProperty("title", item.Title),
                        new JProperty("description", item.Description),
                        new JProperty("submission_date", item.Date.ToString()),
                        new JProperty("tags", tags),
                        new JProperty("key", item.Key),
                        new JProperty("VideoItem", "")
                    );
                    source.TrySetResult(result);
                }
                else
                {
                    Exception exception = new Exception(error.LocalizedDescription);
                    source.TrySetException(exception);
                }
            });

            return await source.Task;
        }
    }
}