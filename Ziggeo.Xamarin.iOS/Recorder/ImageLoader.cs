using System;
using UIKit;
using Foundation;

namespace Ziggeo
{
    public class ImageLoader
    {
        public static UIImage GetImageFromResource(string resourceName)
        {
            return new UIImage(NSBundle.MainBundle.PathForResource(resourceName, "png"));
        }
    }
}
