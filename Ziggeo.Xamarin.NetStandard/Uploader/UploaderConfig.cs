using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public class UploaderConfig : BaseConfig, IUploaderEventsListener
    {
        public static int UPLOADING_ERROR_ACTION_DELETE_VIDEO = 554;
        public static int UPLOADING_ERROR_ACTION_ERROR_NOTIFICATION = 553;
        public static int UPLOADING_ERROR_ACTION_RELOAD_VIDEO = 552;
        public bool ShouldTurnOffUploader { get; set; } = false;
        public bool ShouldUseWifiOnly { get; set; } = false;
        public bool ShouldStartAsForeground { get; set; } = false;
        
        public int LostConnectionAction { get; set; } = UPLOADING_ERROR_ACTION_ERROR_NOTIFICATION;

        public event ErrorDelegate Error;

        public void InvokeError(Exception e)
        {
            Error?.Invoke(e);
        }

        public event UploadingStarted UploadingStarted;

        public void InvokeUploadingStarted(string videoToken)
        {
            UploadingStarted?.Invoke(videoToken);
        }

        public event UploadProgress UploadProgress;

        public void InvokeUploadProgress(string videoToken, string videoPath, long uploadedBytes, long totalBytes)
        {
            UploadProgress?.Invoke(videoToken, videoPath, uploadedBytes, totalBytes);
        }

        public event Uploaded Uploaded;

        public void InvokeUploaded(string path, string videoToken)
        {
            Uploaded?.Invoke(path, videoToken);
        }

        public event Verified Verified;

        public void InvokeVerified(string videoToken)
        {
            Verified?.Invoke(videoToken);
        }

        public event Processing Processing;

        public void InvokeProcessing(string videoToken)
        {
            Processing?.Invoke(videoToken);
        }

        public event Processed Processed;

        public void InvokeProcessed(string videoToken)
        {
            Processed?.Invoke(videoToken);
        }
    }
}