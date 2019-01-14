// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Ziggeo
{
    [Register ("PreviewAndUpload")]
    partial class PreviewAndUpload
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton playPauseButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Root { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton uploadButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView VideoPlaceholder { get; set; }

        [Action ("CancelButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CancelButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("PlayPauseButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PlayPauseButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("UploadButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UploadButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (cancelButton != null) {
                cancelButton.Dispose ();
                cancelButton = null;
            }

            if (playPauseButton != null) {
                playPauseButton.Dispose ();
                playPauseButton = null;
            }

            if (Root != null) {
                Root.Dispose ();
                Root = null;
            }

            if (uploadButton != null) {
                uploadButton.Dispose ();
                uploadButton = null;
            }

            if (VideoPlaceholder != null) {
                VideoPlaceholder.Dispose ();
                VideoPlaceholder = null;
            }
        }
    }
}