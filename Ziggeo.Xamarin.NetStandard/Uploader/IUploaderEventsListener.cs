using System.Collections;
using System.Collections.Generic;
using Ziggeo;

namespace Ziggeo
{
    public delegate void UploadingStarted(string videoToken);

    public delegate void UploadProgress(string videoToken, string videoPath, long uploadedBytes, long totalBytes);

    public delegate void Uploaded(string path, string videoToken);

    public delegate void Verified(string videoToken);

    public delegate void Processing(string videoToken);

    public delegate void Processed(string videoToken);

    public interface IUploaderEventsListener : IErrorEventsListener
    {
        event UploadingStarted UploadingStarted;
        void InvokeUploadingStarted(string videoToken);

        event UploadProgress UploadProgress;
        void InvokeUploadProgress(string videoToken, string videoPath, long uploadedBytes, long totalBytes);

        event Uploaded Uploaded;
        void InvokeUploaded(string path, string videoToken);

        event Verified Verified;
        void InvokeVerified(string videoToken);

        event Processing Processing;
        void InvokeProcessing(string videoToken);

        event Processed Processed;
        void InvokeProcessed(string videoToken);
    }
}