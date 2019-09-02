using System;
using System.Net;
using Android.Runtime;
using Com.Ziggeo.Androidsdk.Xamarin.Delegates;
using IO.Reactivex.Functions;

namespace Ziggeo.Services.NativeDelegates
{
    public class NVideoNVideoTokenFileDelegate : Java.Lang.Object, IVideoTokenFileDelegate
    {
        public NVideoNVideoTokenFileDelegate(Action<string, string> onCompleted)
        {
            _onCompleted = onCompleted;
        }

        private readonly Action<string, string> _onCompleted;

        public void Update(string token, string fileName)
        {
            _onCompleted?.Invoke(token, fileName);
        }
    }
}