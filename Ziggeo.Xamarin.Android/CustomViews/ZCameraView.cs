using Android.Content;
using Android.Util;
using Java.IO;
using Java.Text;
using Java.Util;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZCameraView : Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView
    {
        private CameraRecorderConfig _config;
        private File _recordedFile = null;
        private ZiggeoApplication _ziggeo;

        public ZCameraView(Context context) : base(context)
        {
            init();
        }

        public ZCameraView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public ZCameraView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        private void init()
        {
            _config = _ziggeo.CameraRecorderConfig;
        }

        public bool IsRecording()
        {
            return base.IsRecording;
        }

        public string GetRecordedFile()
        {
            return _recordedFile.Path;
        }

        public void Start()
        {
            base.Start();
        }

        public void Stop()
        {
            base.Stop();
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

            _recordedFile = new File(defaultPath, getVideoFileName());

            base.StartRecording(_recordedFile.Path, (int)_config.MaxDuration);
        }

        public void StopRecording()
        {
            if (_ziggeo.Ziggeo.RecorderConfig.Callback != null)
            {
                _config.InvokeRecordingStopped(_recordedFile.Path);
            }

            base.StopRecording();
        }

        public void SwitchCamera()
        {
            var isFacingBack = _config.Facing == (int)CameraRecorderConfig.CameraFacing.Rear;
            base.Facing = isFacingBack
                ? (int)CameraRecorderConfig.CameraFacing.Front
                : (int)CameraRecorderConfig.CameraFacing.Rear;
        }

        private string getVideoFileName()
        {
            return ("Rec_" + formatDate() + ".mp4");
        }

        private string formatDate()
        {
            return new SimpleDateFormat("dd.MM.yyyy_HH.mm.ss").Format(new Date());
        }
    }
}