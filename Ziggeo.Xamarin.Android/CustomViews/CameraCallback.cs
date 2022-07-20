namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class CameraCallback: Com.Ziggeo.Androidsdk.Widgets.Cameraview.BaseCameraView.CameraCallback
    {
        public IRecorderEventsListener Listener { get; set; }

        public CameraCallback(IRecorderEventsListener listener)
        {
            Listener = listener;
        }
        
        public override void CameraOpened()
        {
            base.CameraOpened();
            Listener.InvokeReadyToRecord();
        }

    }
}