using System;
using Com.Ziggeo.Androidsdk.Net.Callbacks;
using Java.IO;
using Square.OkHttp3;
using IOException = Java.IO.IOException;

namespace Ziggeo.Services
{
    public class ProgressCallback : Java.Lang.Object, IProgressCallback
    {
        public ProgressCallback(Action<ICall, Response> onResponse,
            Action<ICall, IOException> onFailure,
            Action<string, File, long, long> onProgress)
        {
            _onResponse = onResponse;
            _onFailure = onFailure;
            _onProgress = onProgress;
        }

        private readonly Action<ICall, Response> _onResponse;
        private readonly Action<ICall, IOException> _onFailure;
        private readonly Action<string, File, long, long> _onProgress;

        public void OnFailure(ICall call, IOException exception)
        {
            _onFailure?.Invoke(call, exception);
        }

        public void OnResponse(ICall call, Response response)
        {
            _onResponse?.Invoke(call, response);
        }

        public void OnProgressUpdate(string token, File file, long sent, long total)
        {
            _onProgress?.Invoke(token, file, sent, total);
        }

        [Obsolete]
        public void OnProgressUpdate(long p0, long p1)
        {
        }
    }
}