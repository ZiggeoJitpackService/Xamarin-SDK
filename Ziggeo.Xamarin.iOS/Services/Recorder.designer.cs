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
    [Register ("Recorder")]
    partial class Recorder
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Ziggeo.AudioLevelView audioLevelView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cameraButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton cancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel durationLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Ziggeo.FaceOutlineView faceOutlineView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Ziggeo.LuxMeterView luxMeter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        Ziggeo.CapturePreviewView PreviewView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton recordButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Root { get; set; }

        [Action ("CameraButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CameraButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CancelButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CancelButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("RecordButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RecordButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (audioLevelView != null) {
                audioLevelView.Dispose ();
                audioLevelView = null;
            }

            if (cameraButton != null) {
                cameraButton.Dispose ();
                cameraButton = null;
            }

            if (cancelButton != null) {
                cancelButton.Dispose ();
                cancelButton = null;
            }

            if (durationLabel != null) {
                durationLabel.Dispose ();
                durationLabel = null;
            }

            if (faceOutlineView != null) {
                faceOutlineView.Dispose ();
                faceOutlineView = null;
            }

            if (luxMeter != null) {
                luxMeter.Dispose ();
                luxMeter = null;
            }

            if (PreviewView != null) {
                PreviewView.Dispose ();
                PreviewView = null;
            }

            if (recordButton != null) {
                recordButton.Dispose ();
                recordButton = null;
            }

            if (Root != null) {
                Root.Dispose ();
                Root = null;
            }
        }
    }
}