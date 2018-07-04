using System;
using Com.Ziggeo.Androidsdk.Recording;
using Java.Lang;
using Square.OkHttp3;
using IOException = Java.IO.IOException;
using Uri = Android.Net.Uri;

namespace Ziggeo
{
    public class RecorderCallback : Java.Lang.Object, IVideoRecordingCallback
    {
        public RecorderCallback(Action<Throwable> onError, Action onStarted, Action<string> onStopped,
            Action<Uri> onUploadingStarted)
        {
            _onError = onError;
            _onStarted = onStarted;
            _onStopped = onStopped;
            _onUploadingStarted = onUploadingStarted;
        }

        private readonly Action<Throwable> _onError = null;
        private readonly Action _onStarted = null;
        private readonly Action<string> _onStopped = null;
        private readonly Action<Uri> _onUploadingStarted = null;

        public void OnError(Throwable exception)
        {
            _onError?.Invoke(exception);
        }

        public void OnStarted()
        {
            _onStarted?.Invoke();
        }

        public void OnStopped(string path)
        {
            _onStopped?.Invoke(path);
        }

        public void OnUploadingStarted(Uri fileUri)
        {
            _onUploadingStarted?.Invoke(fileUri);
        }
    }
}