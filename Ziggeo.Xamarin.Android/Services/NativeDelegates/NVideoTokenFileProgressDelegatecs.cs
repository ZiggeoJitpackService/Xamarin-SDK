using System;
using System.Net;
using Android.Runtime;
using Com.Ziggeo.Androidsdk.Xamarin.Delegates;

namespace Ziggeo.Services.NativeDelegates
{
    public class NVideoTokenFileProgressDelegate : Java.Lang.Object, IVideoTokenFileProgressDelegate
    {
        public NVideoTokenFileProgressDelegate(Action<string, string, long, long> onProgress)
        {
            _onProgress = onProgress;
        }

        private readonly Action<string, string, long, long> _onProgress;

        public void Update(string token, string fileName, long sent, long total)
        {
            _onProgress?.Invoke(token, fileName, sent, total);
        }
    }
}