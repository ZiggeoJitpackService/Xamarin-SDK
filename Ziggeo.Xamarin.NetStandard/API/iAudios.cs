using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public interface IAudios

{

        Task<JArray> Index(Dictionary<string, string> data);

        Task<JObject> Get(string tokenOrKey);

        Task<JObject> Update(string tokenOrKey, Dictionary<string, string> data);

        Task<JObject> Update(string json);

        Task Destroy(string tokenOrKey);

        Task<JObject> Create(Dictionary<string, string> data);

        Task<JObject> Create(string filePath, Dictionary<string, string> data);
   
    }
}
