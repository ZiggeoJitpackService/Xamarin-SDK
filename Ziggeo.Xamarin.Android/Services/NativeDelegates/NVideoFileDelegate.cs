using System;
using Android.Runtime;
using Com.Ziggeo.Androidsdk.Xamarin.Delegates;
using IO.Reactivex.Functions;

namespace Ziggeo.Services.NativeDelegates
{
    public class NVideoFileDelegate : Java.Lang.Object, IVideoFileDelegate
    {
        public NVideoFileDelegate(Action<string> onStarted)
        {
            _onStarted = onStarted;
        }

        private readonly Action<string> _onStarted;

        public void Update(string fileName)
        {
            _onStarted?.Invoke(fileName);
        }
    }
}