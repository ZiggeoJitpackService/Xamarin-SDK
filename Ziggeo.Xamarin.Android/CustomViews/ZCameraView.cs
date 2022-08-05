using Android.Content;
using Android.Util;
using Com.Ziggeo.Androidsdk;
using Com.Ziggeo.Androidsdk.Widgets.Cameraview;
using Java.IO;
using Java.Text;
using Java.Util;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZCameraView : CameraView, IZCameraView
    {
        private CameraRecorderConfig _config;
        private File _recordedFile;
        private IZiggeoApplication _Ziggeo;
        private Context _context;

        public void SetZiggeo(IZiggeoApplication Ziggeo)
        {
            _Ziggeo = Ziggeo;
            Init();
        }
        public ZCameraView(Context context) : base(context)
        {
            _context = context;
        }

        public ZCameraView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            _context = context;

        }

        public ZCameraView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            _context = context;

        }

        private void Init()
        {
            _config = _Ziggeo.CameraRecorderConfig;
        }

        public new bool IsRecording()
        {
            return base.IsRecording;
        }

        public string GetRecordedFile()
        {
            return _recordedFile.Path;
        }

        public void StartRecording()
        {
            if (_recordedFile != null)
            {
                _recordedFile.Delete();
                _config?.InvokeRerecord();
            }

            var defaultPath = CacheConfig.GetDefault(_context).CacheRoot;
            if (!defaultPath.Exists())
            {
                defaultPath.Mkdir();
            }

            _recordedFile = new File(defaultPath, GetVideoFileName());
            base.StartRecording(_recordedFile.Path, (int)_config.MaxDuration);
        }

        public new void StopRecording()
        {
            _config?.InvokeRecordingStopped(_recordedFile.Path);

            base.StopRecording();
        }
        
        public new void Stop()
        {
            base.Stop();
        }
        
        public new void Start()
        {
            base.Start();
        }

        public void SwitchCamera()
        {
            var isFacingBack = _config.Facing == (int)CameraRecorderConfig.CameraFacing.Rear;
            base.Facing = isFacingBack
                ? (int)CameraRecorderConfig.CameraFacing.Front
                : (int)CameraRecorderConfig.CameraFacing.Rear;
        }

        public void LoadConfig()
        {
            _config?.InvokeLoaded();
            base.Quality = _config.VideoQuality;
            base.Facing = _config.Facing;
            base.SetCameraCallback(new CustomViews.CameraCallback(_config));
            base.SetRecorderCallback(new RecorderCallback(_config));
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