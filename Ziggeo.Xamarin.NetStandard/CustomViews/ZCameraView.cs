namespace Ziggeo.Xamarin.NetStandard.CustomViews
{
    public interface IZCameraView
    {
        bool IsRecording();

        string GetRecordedFile();

        void StartRecording();

        void StopRecording();

        void SwitchCamera();

        void LoadConfig();
    }
}