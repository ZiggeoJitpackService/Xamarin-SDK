using System;
using System.Collections.Generic;

namespace Ziggeo
{
    public delegate void AccessGrantedDelegate();

    public delegate void AccessForbiddenDelegate(IList<string> permissions);

    public interface IPermissionEventsListener : IErrorEventsListener
    {
        event AccessGrantedDelegate AccessGranted;
        event AccessForbiddenDelegate AccessForbidden;
    }
}