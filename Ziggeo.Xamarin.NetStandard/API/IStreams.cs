using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public interface IStreams
    {
        Task<JObject> Create(string tokenOrKey);

        Task AttachImage(string tokenOrKey, string streamToken, string filePath);

        Task<JObject> Bind(string tokenOrKey, string streamToken);

        Task AttachVideo(string tokenOrKey, string streamToken, string filePath);
    }
}