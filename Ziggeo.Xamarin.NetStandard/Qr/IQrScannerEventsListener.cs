using Ziggeo;

namespace Ziggeo
{
    public delegate void DecodedDelegate(string qr);

    public interface IQrScannerEventsListener : ICommonEventsListener, IPermissionEventsListener,
        IHardwareEventsListener
    {
        event DecodedDelegate Decoded;
        void InvokeDecoded(string value);
    }
}