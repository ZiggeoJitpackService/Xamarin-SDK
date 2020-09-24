using System;
using System.Collections.Generic;
using Java.Lang;

namespace Ziggeo
{
    public class FileSelectorCallback : Com.Ziggeo.Androidsdk.Callbacks.FileSelectorCallback
    {
        public FileSelectorConfig Config { get; set; }

        public FileSelectorCallback(FileSelectorConfig config)
        {
            Config = config;
        }

        public override void AccessForbidden(IList<string> permissions)
        {
            base.AccessForbidden(permissions);
            Config.InvokeAccessForbidden(permissions);
        }

        public override void AccessGranted()
        {
            base.AccessGranted();
            Config.InvokeAccessGranted();
        }

        public override void CanceledByUser()
        {
            base.CanceledByUser();
            Config.InvokeCancelledByUser();
        }

        public override void Error(Throwable throwable)
        {
            base.Error(throwable);
            Config.InvokeError(throwable);
        }

        public override void Loaded()
        {
            base.Loaded();
            Config.InvokeLoaded();
        }

        public override void UploadSelected(IList<string> paths)
        {
            base.UploadSelected(paths);
            Config.InvokeUploadSelected(paths);
        }
    }
}