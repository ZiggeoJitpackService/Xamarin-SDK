using System;
using System.Threading.Tasks;
using System.IO;
using Foundation;

namespace Ziggeo
{
    public class ZiggeoConnectImpl : ZiggeoConnect
    {
        public ZiggeoConnectImpl(string token) : base(token, new ZiggeoConfig(token))
        {
        }

        public override Task<byte[]> RequestData(Method method, string path, string contentType, byte[] body)
        {
            string requestString = GetServerURL(path);
            NSMutableUrlRequest request = new NSMutableUrlRequest(new NSUrl(requestString));
            request.HttpMethod = Enum.GetName(typeof(Method), method);
            Console.WriteLine("Request: {0} {1}", method, requestString);
            if ((method == Method.POST || method == Method.DELETE) && body != null && body.Length > 0)
            {
                if (method == Method.DELETE) Console.WriteLine("delete body detected");
                request.Body = NSData.FromArray(body);
                request["Content-Type"] = new NSString(contentType);
                if (body != null && body.Length > 0)
                {
                    request["Content-Length"] = new NSString(request.Body.Length.ToString());
                    Console.WriteLine("body: {0}\n{1}", contentType, System.Text.Encoding.UTF8.GetString(body));
                }
            }



            var tcs = new TaskCompletionSource<byte[]>();
            var task = NSUrlSession.SharedSession.CreateDataTask(request,
                (NSData data, NSUrlResponse response, NSError error) =>
                {
                    if (error != null)
                    {
                        tcs.TrySetException(new Exception(error.ToString()));
                    }
                    else
                    {
                        byte[] result = new byte[] { };
                        if (data != null && data.Length > 0) result = data.ToArray();
                        tcs.TrySetResult(result);
                    }
                });
            task.Resume();
            return tcs.Task;
        }

        private class BackgroundSessionDelegateProxy : NSUrlSessionDataDelegate
        {
            public delegate void SendBodyDataDelegate(NSUrlSession session, NSUrlSessionTask task, long bytesSent,
                long totalBytesSent, long totalBytesExpectedToSend);

            public event SendBodyDataDelegate OnSendBodyData = null;

            public override void DidSendBodyData(NSUrlSession session, NSUrlSessionTask task, long bytesSent,
                long totalBytesSent, long totalBytesExpectedToSend)
            {
                OnSendBodyData?.Invoke(session, task, bytesSent, totalBytesSent, totalBytesExpectedToSend);
            }

            public delegate void ReceiveDataDelegate(NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data);

            public event ReceiveDataDelegate OnReceiveData = null;

            public override void DidReceiveData(NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data)
            {
                OnReceiveData?.Invoke(session, dataTask, data);
            }

            public delegate void CompleteWithErrorDelegate(NSUrlSession session, NSUrlSessionTask task, NSError error);

            public event CompleteWithErrorDelegate OnCompleteOrError = null;

            public override void DidCompleteWithError(NSUrlSession session, NSUrlSessionTask task, NSError error)
            {
                OnCompleteOrError?.Invoke(session, task, error);
            }
        }

        public override async Task<byte[]> BackgroundUpload(string destinationPath, string remoteFileName,
            string identifier, string sourceFileName)
        {
            var requestParams = await AddSessionData(null, destinationPath);
            string parameters = SerializeParameters(requestParams);
            destinationPath += string.Format("?{0}", parameters);

            string boundaryTemplate = "----WebKitFormBoundaryLEjTQVMVbVg9HRYu";
            string contentType = string.Format("multipart/form-data; boundary={0}", boundaryTemplate);
            string outputFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(),
                string.Format("video{0}.mp4", NSProcessInfo.ProcessInfo.GloballyUniqueString));
            long contentSize =
                await GenerateMultipartBody(sourceFileName, outputFileName, remoteFileName, boundaryTemplate);
            NSUrlSessionConfiguration sessionConfiguration =
                NSUrlSessionConfiguration.CreateBackgroundSessionConfiguration(identifier);
            var tcs = new TaskCompletionSource<byte[]>();
            MemoryStream responseData = new MemoryStream();
            BackgroundSessionDelegateProxy sessionDelegate = new BackgroundSessionDelegateProxy();
            sessionDelegate.OnCompleteOrError +=
                (NSUrlSession session, NSUrlSessionTask uploadingTask, NSError error) =>
                {
                    if (error != null) tcs.TrySetException(new Exception(error.ToString()));
                    else tcs.TrySetResult(responseData.ToArray());
                };
            sessionDelegate.OnReceiveData += (NSUrlSession session, NSUrlSessionDataTask dataTask, NSData data) =>
            {
                if (data != null && data.Length > 0)
                {
                    var buffer = data.ToArray();
                    responseData.Write(buffer, 0, buffer.Length);
                    Console.WriteLine("data received: {0}", buffer.Length);
                }
            };
            sessionDelegate.OnSendBodyData +=
                (NSUrlSession session, NSUrlSessionTask dataTask, long bytesSent, long totalBytesSent,
                    long totalBytesExpectedToSend) =>
                {
                    Console.WriteLine("uploading progress: {0}/{1}", totalBytesSent, totalBytesExpectedToSend);
                };
            NSUrlSession backgroundSession =
                NSUrlSession.FromConfiguration(sessionConfiguration, sessionDelegate as INSUrlSessionDelegate, null);
            string requestString = GetServerURL(destinationPath);
            NSMutableUrlRequest request = new NSMutableUrlRequest(new NSUrl(requestString));
            request.HttpMethod = "POST";
            request["Content-Type"] = new NSString(contentType);
            request["Content-Length"] = new NSString(contentSize.ToString());
            var task = backgroundSession.CreateUploadTask(request, NSUrl.CreateFileUrl(new string[] {outputFileName}));
            task.Resume();
            Console.WriteLine("background upload: POST {0}", requestString);
            return await tcs.Task;
        }
    }
}