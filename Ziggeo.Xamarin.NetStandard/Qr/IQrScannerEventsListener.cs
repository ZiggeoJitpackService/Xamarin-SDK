using Ziggeo;

namespace Ziggeo
{
    public delegate void DecodedDelegate(string qr);

    public interface IQrScannerEventsListener : ICommonEventsListener, IPermissionEventsListener,
        ICameraHardwareEventsListener, IMicHardwareEventsListener
    {
        event DecodedDelegate Decoded;
        void InvokeDecoded(string value);
    }
}