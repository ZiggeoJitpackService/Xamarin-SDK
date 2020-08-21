using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ziggeo
{
    public interface IZiggeoQrScanner: IQrScannerEventsListener
    {
        Task StartQrScanner();
    }
}
