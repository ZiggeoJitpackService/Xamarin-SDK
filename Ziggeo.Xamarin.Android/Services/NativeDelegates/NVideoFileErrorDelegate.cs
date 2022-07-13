using System;
using Com.Ziggeo.Androidsdk.Xamarin.Delegates;
using Java.Lang;
using Exception = System.Exception;

namespace Ziggeo.Services.NativeDelegates
{
    public class NVideoFileErrorDelegate : Java.Lang.Object, IVideoFileErrorDelegate
    {
        public NVideoFileErrorDelegate(Action<string, Exception> onError)
        {
            _onError = onError;
        }

        private readonly Action<string, Exception> _onError;

        public void Update(string fileName, Throwable exception)
        {
            _onError?.Invoke(fileName, exception);
        }
    }
}