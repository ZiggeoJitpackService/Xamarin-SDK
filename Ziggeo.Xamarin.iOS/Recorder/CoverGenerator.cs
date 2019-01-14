using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using AVFoundation;

namespace Ziggeo
{
    public class CoverGenerator
    {
        public CoverGenerator(NSUrl filePath)
        {
            this.FilePath = filePath;
        }

        public NSUrl FilePath
        {
            get;
            private set;
        }

        public delegate void CoverGeneratorResultHandler(UIImage cover);
        public void GenerateCover(CoverGeneratorResultHandler handler)
        {
            AVUrlAsset asset = new AVUrlAsset(FilePath, null as NSDictionary);
            NSValue[] timestamp = new NSValue[] {
                NSValue.FromCMTime(new CoreMedia.CMTime(asset.Duration.Value / 2, asset.Duration.TimeScale))
            };
            GenerateCovers(handler, asset, timestamp);
        }

        public void GenerateCovers(CoverGeneratorResultHandler handler, int intervalSeconds)
        {
            AVUrlAsset asset = new AVUrlAsset(FilePath, null as NSDictionary);
            List<NSValue> timestamps = new List<NSValue>();
            for (Int64 i = 0; i < asset.Duration.Value; i+= intervalSeconds * asset.Duration.TimeScale)
            {
                timestamps.Add(NSValue.FromCMTime(new CoreMedia.CMTime(i, asset.Duration.TimeScale)));
            }
            Console.WriteLine("generating covers[{0}] for {1}", timestamps.Count, FilePath.Path);
            GenerateCovers(handler, asset, timestamps.ToArray());
        }

        private void GenerateCovers(CoverGeneratorResultHandler handler, AVUrlAsset asset, NSValue[] timestamps)
        {
            AVAssetImageGenerator generator = new AVAssetImageGenerator(asset);
            generator.AppliesPreferredTrackTransform = true;
            generator.MaximumSize = new CoreGraphics.CGSize(640, 480);
            int handlerCalled = 0;
            generator.GenerateCGImagesAsynchronously(timestamps, (CoreMedia.CMTime requestedTime, IntPtr imageRef, CoreMedia.CMTime actualTime, AVAssetImageGeneratorResult coverResult, NSError error) =>
            {
                UIImage image = null;              
                if(error == null)    
                {
                    image = new UIImage(new CoreGraphics.CGImage(imageRef));
                }
                else
                {
                    Console.WriteLine("cover generator error: {0}", error);
                }
                if(handlerCalled < timestamps.Length)
                {
                    handler?.Invoke(image);
                    handlerCalled++;
                }
            });
        }
    }
}
