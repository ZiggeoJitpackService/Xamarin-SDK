namespace Ziggeo.Xamarin.NetStandard.CustomViews
{
    public interface IZCameraView
    {
        void SetZiggeo(IZiggeoApplication Ziggeo);
        bool IsRecording();

        string GetRecordedFile();

        void StartRecording();

        void StopRecording();

        void Stop();

        void Start();

        void SwitchCamera();

        void LoadConfig();
    }
}