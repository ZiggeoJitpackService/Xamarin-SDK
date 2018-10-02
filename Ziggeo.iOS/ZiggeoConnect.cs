using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Ziggeo
{
    public abstract class ZiggeoConnect
    {
        public enum Method
        {
            GET,
            POST,
            DELETE,
            PUT
        }

        public ZiggeoConnect(string token, ZiggeoConfig config)
        {
            Config = config;
            Token = token;
        }

        protected ZiggeoConfig Config { get; private set; }

        protected string Token { get; private set; }

        protected string SessionValue { get; private set; }

        protected string SessionKey { get; private set; }

        protected string SerializeParameters(IDictionary<string, string> parameters)
        {
            string result = string.Empty;
            if (parameters != null && parameters.Count > 0)
            {
                foreach (var item in parameters)
                {
                    result += string.Format("{0}={1}&", item.Key, item.Value);
                }
            }

            return result;
        }

        public async Task<byte[]> RequestDataAsync(Method method, string path, Dictionary<string, string> requestParams)
        {
            requestParams = await AddSessionData(requestParams, path);
            string parameters = SerializeParameters(requestParams);
            if (method != Method.POST) path += string.Format("?{0}", parameters);
            byte[] body = null;
            if (method == Method.POST || method == Method.DELETE)
            {
                if (method == Method.DELETE) Console.WriteLine("delete body added");
                body = System.Text.Encoding.UTF8.GetBytes(parameters);
            }

            return await RequestData(method, path, "application/x-www-form-urlencoded", body);
        }

        public string GetCDNURL(string path)
        {
            return string.Format("{0}/v1/applications/{1}{2}", Config.CDNApiURL, Token, path);
        }

        public string GetServerURL(string path)
        {
            return string.Format("{0}/v1/applications/{1}{2}", Config.ServerApiURL, Token,
                path);
        }

        public abstract Task<byte[]> RequestData(Method method, string path, string contentType, byte[] body);

        public async Task<string> RequestString(Method method, string path, Dictionary<string, string> requestParams)
        {
            var data = await RequestDataAsync(method, path, requestParams);
            string result = System.Text.Encoding.UTF8.GetString(data);
            Console.WriteLine("string dump: {0}", result);
            return result;
        }

        public async Task<JObject> RequestJSON(Method method, string path, Dictionary<string, string> requestParams)
        {
            string jsonDump = await RequestString(method, path, requestParams);
            Console.WriteLine("JSON dump: {0}", jsonDump);
            return JObject.Parse(jsonDump);
        }

        public async Task<JArray> RequestJSONArray(Method method, string path, Dictionary<string, string> requestParams)
        {
            string jsonDump = await RequestString(method, path, requestParams);
            Console.WriteLine("JSON dump: {0}", jsonDump);
            return JArray.Parse(jsonDump);
        }

        public abstract Task<byte[]> BackgroundUpload(string destinationPath, string remoteFileName, string identifier,
            string sourceFileName);

        protected async Task<long> GenerateMultipartBody(string sourceFile, string destinationFile,
            string remoteFileName, string boundaryTemplate)
        {
            long result = 0;
            if (System.IO.File.Exists(sourceFile))
            {
                using (Stream inputStream = File.OpenRead(sourceFile))
                {
                    byte[] boundary = System.Text.Encoding.UTF8.GetBytes(string.Format("--{0}\r\n", boundaryTemplate));
                    byte[] trailer =
                        System.Text.Encoding.UTF8.GetBytes(string.Format("\r\n--{0}--\r\n", boundaryTemplate));
                    byte[] disposition = System.Text.Encoding.UTF8.GetBytes(string.Format(
                        "Content-Disposition: form-data; name=\"file\"; filename=\"{0}\";\r\nContent-Type: video/mp4\r\n\r\n",
                        remoteFileName));
                    using (Stream outputStream = File.OpenWrite(destinationFile))
                    {
                        await outputStream.WriteAsync(boundary, 0, boundary.Length);
                        await outputStream.WriteAsync(disposition, 0, disposition.Length);
                        await inputStream.CopyToAsync(outputStream);
                        await outputStream.WriteAsync(trailer, 0, trailer.Length);
                        result = outputStream.Position;
                    }
                }
            }

            return result;
        }

        private async Task<string> GetSession()
        {
            if (string.IsNullOrEmpty(SessionValue))
            {
                var session = await RequestJSON(Method.POST, "/session", null);
                SessionValue = session["token"].Value<string>();
                SessionKey = string.Format("i07af2jp98rvoctt26y5egy3{0}", Token);
            }
            return SessionValue;
        }

        public async Task<Dictionary<string, string>> AddSessionData(Dictionary<string, string> requestParams, string path)
        {
            if("/session".Equals(path, StringComparison.CurrentCultureIgnoreCase))
            {
                return requestParams;
            }
            else
            {
                await GetSession();
                var result = requestParams != null ? new Dictionary<string, string>(requestParams) : new Dictionary<string, string>();
                result[SessionKey] = SessionValue;
                if (!string.IsNullOrEmpty(ClientAuthToken)) result["client_auth"] = ClientAuthToken;
                if (!string.IsNullOrEmpty(ServerAuthToken)) result["server_auth"] = ServerAuthToken;
                return result;
            }
        }

        public string ServerAuthToken { get; set; }
        public string ClientAuthToken { get; set; }
    }
}