using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public class FileSelectorConfig : BaseConfig, IFileSelectorEventsListener
    {
        public event ErrorDelegate Error;

        public void InvokeError(Exception e)
        {
            Error?.Invoke(e);
        }

        public event LoadedDelegate Loaded;

        public void InvokeLoaded()
        {
            Loaded?.Invoke();
        }

        public event CanceledByUserDelegate CanceledByUser;

        public void InvokeCancelledByUser()
        {
            CanceledByUser?.Invoke();
        }

        public event AccessGrantedDelegate AccessGranted;

        public void InvokeAccessGranted()
        {
            AccessGranted?.Invoke();
        }

        public event AccessForbiddenDelegate AccessForbidden;

        public void InvokeAccessForbidden(IList<string> permissions)
        {
            AccessForbidden?.Invoke(permissions);
        }

        public event UploadSelectedDelegate UploadSelected;

        public void InvokeUploadSelected(IList<string> paths)
        {
            UploadSelected?.Invoke(paths);
        }
    }
}