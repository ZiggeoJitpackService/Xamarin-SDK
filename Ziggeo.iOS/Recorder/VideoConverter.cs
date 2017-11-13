using System;
using System.Linq;
using System.Threading.Tasks;
using AVFoundation;
using Foundation;

namespace Ziggeo
{
    public class VideoConverter
    {        
        public VideoConverter(string sourceFile)
        {
            this.SourceFile = sourceFile;
        }

        public string SourceFile
        {
            get;
            private set;
        }

        public Task<string> Convert(string preset)
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            AVUrlAsset asset = new AVUrlAsset(NSUrl.CreateFileUrl(new string[] { SourceFile }));
            string[] compatiblePresets = AVAssetExportSession.ExportPresetsCompatibleWithAsset(asset);
            try
            {
                if (compatiblePresets.Contains(preset))
                {
                    AVAssetExportSession exportSession = new AVAssetExportSession(asset, preset);
                    string outputFileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), string.Format("converted{0}.mp4", NSProcessInfo.ProcessInfo.GloballyUniqueString));
                    Console.WriteLine("converting from {0} to {1}", SourceFile, outputFileName);
                    exportSession.OutputUrl = NSUrl.CreateFileUrl(new string[] { outputFileName });
                    exportSession.OutputFileType = AVFileType.Mpeg4;
                    exportSession.ExportAsynchronously(() =>
                    {
                        try
                        {
                            switch (exportSession.Status)
                            {
                                case AVAssetExportSessionStatus.Cancelled:
                                    throw new Exception("coverting session was cancelled");
                                case AVAssetExportSessionStatus.Failed:
                                    throw new Exception("converting session failed");
                                case AVAssetExportSessionStatus.Completed:
                                    tcs.SetResult(outputFileName);
                                    break;
                                default: throw new Exception("converting session unknown error");
                            }
                        }
                        catch(Exception ex)
                        {
                            tcs.SetException(ex);
}
                    });
                }
                else throw new Exception(string.Format("preset {0} is not compatible with the asset", preset));
            }
            catch(Exception ex)
            {
                tcs.SetException(ex);
            }
            return tcs.Task;
        }
    }
}
