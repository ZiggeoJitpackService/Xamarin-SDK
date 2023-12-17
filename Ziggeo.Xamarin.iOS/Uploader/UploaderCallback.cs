using Foundation;
using System;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class UploaderCallback : ZiggeoUploadingDelegate
    {
        public UploaderConfig Config { get; set; }

        public UploaderCallback(UploaderConfig config)
        {
            Config = config;
        }

        public override void PreparingToUploadWithPath(string sourcePath)
        {
            throw new NotImplementedException();
        }

        public override void UploadStartedWithPath(string sourcePath, string token, string streamToken, NSUrlSessionTask uploadingTask)
        {
            Config.InvokeUploadingStarted(token);
        }

        public override void UploadProgressWithPath(string sourcePath, string token, string streamToken, int bytesSent, int totalBytes)
        {
            Config.InvokeUploadProgress(token, sourcePath, bytesSent, totalBytes);
        }

        public override void UploadFinishedWithPath(string sourcePath, string token, string streamToken)
        {
            Config.InvokeUploaded(sourcePath, token);
        }

        public override void UploadVerifiedWithPath(string sourcePath, string token, string streamToken, NSUrlResponse response, NSError error, NSDictionary json)
        {
            Config.InvokeVerified(token);
        }

        public override void UploadProcessingWithPath(string sourcePath, string token, string streamToken)
        {
            Config.InvokeProcessing(token);
        }

        public override void UploadProcessedWithPath(string sourcePath, string token, string streamToken)
        {
            Config.InvokeProcessed(token);
        }

        public override void DeleteWithToken(string token, string streamToken, NSUrlResponse response, NSError error, NSDictionary json)
        {
            throw new NotImplementedException();
        }

        public override void CancelUploadByPath(string sourcePath, bool deleteFile)
        {
            throw new NotImplementedException();
        }

        public override void CancelCurrentUpload(bool deleteFile)
        {
            throw new NotImplementedException();
        }

        public override void ErrorWithInfo(RecordingInfo info, NSError error, int lostConnectionAction)
        {
            Exception throwable = new Exception(error.LocalizedDescription);
            Config.InvokeError(throwable);
        }

        public override void ErrorWithError(NSError error)
        {
            Exception throwable = new Exception(error.LocalizedDescription);
            Config.InvokeError(throwable);
        }

        // Common
        public void Error(Exception throwable)
        {
            Config.InvokeError(throwable);
        }
    }
}