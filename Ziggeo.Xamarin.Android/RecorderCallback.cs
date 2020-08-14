using System;
using Java.IO;
using Java.Lang;

namespace Ziggeo
{
    public class RecorderCallback : Com.Ziggeo.Androidsdk.Callbacks.RecorderCallback
    {
        public Action<Throwable> _onError = null;
        public Action _onRecordingStarted = null;
        public Action<string> _onRecordingStopped = null;
        public Action<string> _onUploadingStarted = null;
        public Action<string, string> _onUploadingFinished = null;
        public Action<string, File, long, long> _onUploadingProgress = null;

        // public override void UploadingStarted(string path)
        // {
        //     base.UploadingStarted(path);
        //     _onUploadingStarted?.Invoke(path);
        // }
        //
        // public override void UploadProgress(string token, File file, long sent, long total)
        // {
        //     base.UploadProgress(token, file, sent, total);
        //     _onUploadingProgress?.Invoke(token, file, sent, total);
        // }
        //
        // public override void Uploaded(string path, string token)
        // {
        //     base.Uploaded(path, token);
        //     _onUploadingFinished?.Invoke(path, token);
        // }

        public override void Error(Throwable exception)
        {
            base.Error(exception);
            _onError?.Invoke(exception);
        }

        public override void RecordingStarted()
        {
            base.RecordingStarted();
            _onRecordingStarted?.Invoke();
        }

        public override void RecordingStopped(string path)
        {
            base.RecordingStopped(path);
            _onRecordingStopped?.Invoke(path);
        }
    }
}