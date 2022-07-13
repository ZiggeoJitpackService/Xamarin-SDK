using System;
using Foundation;
using UIKit;
using AVFoundation;
using ObjCRuntime;

namespace Ziggeo
{
    [Register("CapturePreviewView")]
    public class CapturePreviewView : UIView
    {
		public CapturePreviewView(IntPtr handle) : base (handle)
        {
		}

		[Export("layerClass")]
		public static Class LayerClass()
		{
            return new Class(typeof(AVCaptureVideoPreviewLayer));
		}

        public AVCaptureSession Session
        {
            get
            {
                AVCaptureVideoPreviewLayer previewLayer = this.Layer as AVCaptureVideoPreviewLayer;
                return previewLayer.Session;
            }
            set
            {
				AVCaptureVideoPreviewLayer previewLayer = this.Layer as AVCaptureVideoPreviewLayer;
                previewLayer.Session = value;
			}
        }
    }
}
