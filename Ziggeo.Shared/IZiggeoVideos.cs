﻿using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public delegate void VideoFileDelegate(string filename);
    public delegate void VideoTokenFileDelegate(string token, string filename);
    public delegate void VideoTokenFileProgressDelegate(string token, string filename, long bytesSent, long totalBytes);
    public delegate void VideoFileErrorDelegate(string filename, Exception error);
    public interface IZiggeoVideos
    {
        event VideoFileDelegate UploadStarted;
        event VideoTokenFileProgressDelegate UploadProgressChanged;
        event VideoTokenFileDelegate UploadComplete;
        event VideoFileErrorDelegate UploadFailed;

        Task<JArray> Index(Dictionary<string, string> data);

        Task<JObject> Get(string tokenOrKey);

        Task<System.IO.Stream> DownloadVideo(string tokenOrKey);

        Uri GetVideoUrl(string tokenOrKey);

        Task<System.IO.Stream> DownloadImage(string tokenOrKey);

        Task<JObject> ApplyEffect(string tokenOrKey, Dictionary<string, string> data);

        Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data);

        Task Destroy(string tokenOrKey);

        Task<JObject> Create(Dictionary<string, string> data);

        Task<JObject> Create(string filePath, Dictionary<string, string> data);
    }
}