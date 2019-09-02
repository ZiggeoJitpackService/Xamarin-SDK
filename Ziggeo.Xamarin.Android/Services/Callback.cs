using System;
using Square.OkHttp3;
using IOException = Java.IO.IOException;

namespace Ziggeo.Services
{
    public class Callback : Java.Lang.Object, ICallback
    {
        public Callback(Action<ICall, Response> onResponse,
            Action<ICall, IOException> onFailure)
        {
            _onResponseAction = onResponse;
            _onFailureAction = onFailure;
        }

        private readonly Action<ICall, Response> _onResponseAction;
        private readonly Action<ICall, IOException> _onFailureAction;

        public void OnFailure(ICall call, IOException exception)
        {
            _onFailureAction(call, exception);
        }

        public void OnResponse(ICall call, Response response)
        {
            _onResponseAction(call, response);
        }
    }
}