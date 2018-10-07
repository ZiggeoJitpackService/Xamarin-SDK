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
            Action<File, long, long> onProgress)
        {
            _onResponse = onResponse;
            _onFailure = onFailure;
            _onProgress = onProgress;
        }

        private readonly Action<ICall, Response> _onResponse;
        private readonly Action<ICall, IOException> _onFailure;
        private readonly Action<File, long, long> _onProgress;

        public void OnFailure(ICall call, IOException exception)
        {
            _onFailure(call, exception);
        }

        public void OnResponse(ICall call, Response response)
        {
            _onResponse(call, response);
        }

        [Obsolete]
        public void OnProgressUpdate(long p0, long p1)
        {
        }

        public void OnProgressUpdate(File file, long sent, long total)
        {
            _onProgress(file, sent, total);
        }
    }
}