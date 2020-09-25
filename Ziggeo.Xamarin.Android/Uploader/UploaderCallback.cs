using System;
using System.Collections.Generic;
using Java.Lang;

namespace Ziggeo
{
    public class UploaderCallback : Com.Ziggeo.Androidsdk.Callbacks.UploadingCallback
    {
        public UploaderConfig Config { get; set; }

        public UploaderCallback(UploaderConfig config)
        {
            Config = config;
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Config?.InvokeError(throwable);
        }

        public override void Processed(string videoToken)
        {
            base.Processed(videoToken);
            Config?.InvokeProcessed(videoToken);
        }

        public override void Processing(string videoToken)
        {
            base.Processing(videoToken);
            Config?.InvokeProcessing(videoToken);
        }

        public override void UploadProgress(string videoToken, string path, long uploadedBytes, long totalBytes)
        {
            base.UploadProgress(videoToken, path, uploadedBytes, totalBytes);
            Config?.InvokeUploadProgress(videoToken, path, uploadedBytes, totalBytes);
        }

        public override void Uploaded(string path, string videoToken)
        {
            base.Uploaded(path, videoToken);
            Config?.InvokeUploaded(path, videoToken);
        }

        public override void UploadingStarted(string videoToken)
        {
            base.UploadingStarted(videoToken);
            Config?.InvokeUploadingStarted(videoToken);
        }

        public override void Verified(string videoToken)
        {
            base.Verified(videoToken);
            Config?.InvokeVerified(videoToken);
        }
    }
}