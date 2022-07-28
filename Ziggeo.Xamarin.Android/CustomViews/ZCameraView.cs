using Android.Content;
using Android.Util;
using Android.Views;
using Java.IO;
using Java.Text;
using Java.Util;
using Ziggeo.Xamarin.NetStandard.CustomViews;

namespace Ziggeo.Xamarin.Android.CustomViews
{
    public class ZCameraView : Com.Ziggeo.Androidsdk.Widgets.Cameraview.CameraView, Ziggeo.Xamarin.NetStandard.CustomViews.IZCameraView
    {
        private CameraRecorderConfig _config;
        private File _recordedFile;
        private ZiggeoApplication _ziggeo;
        public ZCameraViewCallback ZCallback;

        public ZCameraView(Context context, ZiggeoApplication ziggeo) : base(context)
        {
            _ziggeo = ziggeo;
            Init();
        }
        public ZCameraView(Context context) : base(context)
        {
            Init();
        }

        public ZCameraView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public ZCameraView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        private void Init()
        {
            _config = _ziggeo.CameraRecorderConfig;
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

            base.StartRecording(_recordedFile.Path, (int)_config.MaxDuration);
        }

        public new void StopRecording()
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

        public void LoadConfig()
        {
            if (_ziggeo.Ziggeo.RecorderConfig.Callback != null)
            {
                _config.InvokeLoaded();
            }

            //
            // var analyticsManager = _ziggeo.AnalyticsManager;
            //         analyticsManager.addEmbeddingRecorderLoadedEvent()
            //
            
            base.SetResolution(_ziggeo.Ziggeo.RecorderConfig.Resolution);
            base.SetVideoBitrate(_ziggeo.Ziggeo.RecorderConfig.VideoBitrate);
            base.SetAudioBitrate(_ziggeo.Ziggeo.RecorderConfig.AudioBitrate);
            base.SetAudioSampleRate(_ziggeo.Ziggeo.RecorderConfig.AudioSampleRate);
            base.Quality = _ziggeo.Ziggeo.RecorderConfig.VideoQuality;
            base.Facing = _ziggeo.Ziggeo.RecorderConfig.Facing;
            //todo
            // base.SetCameraCallback(new CameraCallback(_config));
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