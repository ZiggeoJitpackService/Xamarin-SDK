using Android.Content;
using Android.Util;
using Android.Views;
using Java.IO;
using Java.Text;
using Java.Util;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZCameraView : View, Ziggeo.Xamarin.NetStandard.CustomViews.IZCameraView
    {
        private Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView _cameraView;
        private CameraRecorderConfig _config;
        private File _recordedFile;
        private ZiggeoApplication _ziggeo;

        public ZCameraView(Context context, ZiggeoApplication ziggeo) : base(context)
        {
            _ziggeo = ziggeo;
            init();
            _cameraView = new Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView(context: context);
        }
        public ZCameraView(Context context) : base(context)
        {
            init();
            _cameraView = new Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView(context: context);
        }

        public ZCameraView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            _cameraView = new Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView(context: context, attrs: attrs);
        }

        public ZCameraView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            _cameraView =
                new Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView(context: context, attrs: attrs,
                    defStyleAttr: defStyleAttr);
        }

        private void init()
        {
            _config = _ziggeo.CameraRecorderConfig;
        }

        public bool IsRecording()
        {
            return _cameraView.IsRecording;
        }

        public string GetRecordedFile()
        {
            return _recordedFile.Path;
        }

        public void Start()
        {
            _cameraView.Start();
        }

        public void Stop()
        {
            _cameraView.Stop();
        }

        public void StartRecording()
        {
            if (_recordedFile != null)
            {
                _recordedFile.Delete();
                if (_ziggeo.Ziggeo.RecorderConfig.Callback != null)
                {
                    _config.InvokeRerecord();
                }
            }

            File defaultPath = _ziggeo.Ziggeo.RecorderConfig.CacheConfig.CacheRoot;
            if (!defaultPath.Exists())
            {
                defaultPath.Mkdir();
            }

            _recordedFile = new File(defaultPath, GetVideoFileName());

            _cameraView.StartRecording(_recordedFile.Path, (int)_config.MaxDuration);
        }

        public void StopRecording()
        {
            if (_ziggeo.Ziggeo.RecorderConfig.Callback != null)
            {
                _config.InvokeRecordingStopped(_recordedFile.Path);
            }

            _cameraView.StopRecording();
        }

        public void SwitchCamera()
        {
            var isFacingBack = _config.Facing == (int)CameraRecorderConfig.CameraFacing.Rear;
            _cameraView.Facing = isFacingBack
                ? (int)CameraRecorderConfig.CameraFacing.Front
                : (int)CameraRecorderConfig.CameraFacing.Rear;
        }

        private string GetVideoFileName()
        {
            return ("Rec_" + FormatDate() + ".mp4");
        }

        private string FormatDate()
        {
            return new SimpleDateFormat("dd.MM.yyyy_HH.mm.ss").Format(new Date());
        }
    }
}