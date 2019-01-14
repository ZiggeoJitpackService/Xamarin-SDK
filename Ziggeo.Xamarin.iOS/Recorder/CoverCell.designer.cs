// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Ziggeo
{
    [Register ("CoverCell")]
    partial class CoverCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView CoverImage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CoverImage != null) {
                CoverImage.Dispose ();
                CoverImage = null;
            }
        }
    }
}