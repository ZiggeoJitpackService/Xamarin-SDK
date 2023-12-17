using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json.Linq;
using Foundation;
using ZiggeoMediaSDK;

namespace Ziggeo.Xamarin.iOS.Services
{
    public class ZiggeoImageService : IImages
    {
        private readonly ZiggeoMediaSDK.Ziggeo _ziggeoInstance;
        private ZiggeoImages Images { get; }

        public ZiggeoImageService(ZiggeoMediaSDK.Ziggeo ziggeo)
        {
            Images = ziggeo.Images;
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

            Images.Index(dictionary, (jsonArray, error) =>
            {
                if (error == null)
                {
                    var result = new JArray();
                    for (nuint i = 0; i < jsonArray.Count; i++)
                    {
                        var item = jsonArray.GetItem<ContentModel>(i);
                        var jsonObject = new JObject(
                            new JProperty("token", item.Token),
                            new JProperty("state_string", item.StateString),
                            new JProperty("title", item.Title),
                            new JProperty("description", item.Desc),
                            new JProperty("submission_date", item.Date),
                            new JProperty("tags", ""),
                            new JProperty("key", ""),
                            new JProperty("ImageItem", "")
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

            Images.Get(tokenOrKey, dictionary, (content, response, error) =>
            {
                if (error == null)
                {
                    var result = new JObject(
                        new JProperty("token", content.Token),
                        new JProperty("state_string", content.StateString),
                        new JProperty("title", content.Title),
                        new JProperty("description", content.Desc),
                        new JProperty("submission_date", content.Date),
                        new JProperty("tags", ""),
                        new JProperty("key", ""),
                        new JProperty("ImageItem", "")
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

        public async Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Images.Update(tokenOrKey, dictionary, (content, response, error) =>
            {
                if (error == null)
                {
                    var result = new JObject(
                        new JProperty("token", content.Token),
                        new JProperty("state_string", content.StateString),
                        new JProperty("title", content.Title),
                        new JProperty("description", content.Desc),
                        new JProperty("submission_date", content.Date),
                        new JProperty("tags", ""),
                        new JProperty("key", ""),
                        new JProperty("ImageItem", "")
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

        public Task<JObject> Update(string json)
        {
            throw new NotImplementedException();
        }

        public async Task Destroy(string tokenOrKey)
        {
            var source = new TaskCompletionSource<string>();

            Images.Destroy(tokenOrKey, (jsonObject, response, error) =>
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

        public Task<JObject> Create(Dictionary<string, string> data)
        {
            throw new NotImplementedException();
        }

        public async Task<JObject> Create(string filePath, Dictionary<string, string> data)
        {
            var source = new TaskCompletionSource<JObject>();
            NSDictionary dictionary = new NSDictionary();
            if (data != null)
            {
                dictionary = NSDictionary.FromObjectsAndKeys(data.Values.ToArray(), data.Keys.ToArray());
            }

            Images.Create(filePath, dictionary, (jsonObject, response, error) =>
            {
            },
            (totalBytesSent, totalBytesExpectedToSend) =>
            {
            },
            (jsonObject, response, error) =>
            {
                if (error == null)
                {
                    var content = new ContentModel();
                    content.SetInfo(jsonObject);
                    var result = new JObject(
                        new JProperty("token", content.Token),
                        new JProperty("state_string", content.StateString),
                        new JProperty("title", content.Title),
                        new JProperty("description", content.Desc),
                        new JProperty("submission_date", content.Date),
                        new JProperty("tags", ""),
                        new JProperty("key", ""),
                        new JProperty("ImageItem", "")
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

        public async Task<string> GetImageUrl(string tokenOrKey)
        {
            var source = new TaskCompletionSource<string>();
            source.SetResult(Images.GetImageUrl(tokenOrKey));
            return await source.Task;
        }
    }
}