using System;
using System.Collections.Generic;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class FileSelectorCallback : ZiggeoFileSelectorDelegate
    {
        public FileSelectorConfig Config { get; set; }

        public FileSelectorCallback(FileSelectorConfig config)
        {
            Config = config;
        }

        public override void UploadSelected(string[] paths)
        {
            Config.InvokeUploadSelected(paths);
        }

        public override void UploadCancelledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        // Common
        public void AccessForbidden(IList<string> permissions)
        {
            Config.InvokeAccessForbidden(permissions);
        }

        public void AccessGranted()
        {
            Config.InvokeAccessGranted();
        }

        public void CanceledByUser()
        {
            Config.InvokeCancelledByUser();
        }

        public void Error(Exception throwable)
        {
            Config.InvokeError(throwable);
        }

        public void Loaded()
        {
            Config.InvokeLoaded();
        }
    }
}