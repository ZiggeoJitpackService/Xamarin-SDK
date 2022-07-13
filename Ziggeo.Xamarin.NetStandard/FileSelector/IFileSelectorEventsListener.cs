using System.Collections;
using System.Collections.Generic;
using Ziggeo;

namespace Ziggeo
{
    public delegate void UploadSelectedDelegate(IList<string> paths);

    public interface IFileSelectorEventsListener : ICommonEventsListener, IPermissionEventsListener
    {
        event UploadSelectedDelegate UploadSelected;
        void InvokeUploadSelected(IList<string> paths);
    }
}