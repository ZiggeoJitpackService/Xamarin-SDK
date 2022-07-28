using System;

namespace Ziggeo.Xamarin.NetStandard.CustomViews

{
    public class ZCameraViewCallback
    {
        private IZCameraView ZCameraView { get; set; }

        public ZCameraViewCallback(IZCameraView cameraView)
        {
            ZCameraView = cameraView;
        }

        public Action<IZCameraView> IsRecording { get; set; }
        public Action<IZCameraView> GetRecordedFile = null;
        public Action<IZCameraView> StartRecording = null;
        public Action<IZCameraView> StopRecording = null;
        public Action<IZCameraView> SwitchCamera = null;
        public Action<IZCameraView> LoadConfig = null;

        public bool IsCameraRecording(IZCameraView view)
        {
            IsRecording?.Invoke(view);
            return ZCameraView.IsRecording();
        }

        public string GetCameraRecordedFile(IZCameraView view)
        {
            GetRecordedFile?.Invoke(view);
            return ZCameraView.GetRecordedFile();
        }

        public void StartCameraRecording(IZCameraView view)
        {
            StartRecording?.Invoke(view);
            ZCameraView.StartRecording();
        }

        public void StopCameraRecording(IZCameraView view)
        {
            StopRecording?.Invoke(view);
            ZCameraView.StopRecording();
        }

        public void SwitchCameraView(IZCameraView view)
        {
            SwitchCamera?.Invoke(view);
            ZCameraView.SwitchCamera();
        }

        public void LoadCameraConfig(IZCameraView view)
        {
            LoadConfig?.Invoke(view);
            ZCameraView.LoadConfig();
        }
    }
}