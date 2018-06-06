using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.IO;
using Android.Content;
using Com.Ziggeo.Androidsdk;
using Square.OkHttp3;
using IOException = Java.IO.IOException;

namespace Ziggeo
{
    public class Callback : ICallback
    {
        public Callback(Action<ICall, Response> onResponse,
            Action<ICall, IOException> onFailure)
        {
            OnResponseAction = onResponse;
            OnFailureAction = onFailure;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Action<ICall, Response> OnResponseAction { get; private set; }
        public Action<ICall, IOException> OnFailureAction { get; private set; }
        public IntPtr Handle { get; }

        public void OnFailure(ICall call, IOException exception)
        {
            OnFailureAction(call, exception);
        }

        public void OnResponse(ICall call, Response response)
        {
            OnResponseAction(call, response);
        }
    }
}