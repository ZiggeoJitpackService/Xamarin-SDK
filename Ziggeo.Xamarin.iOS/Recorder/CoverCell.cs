using System;

using Foundation;
using UIKit;

namespace Ziggeo
{
    public partial class CoverCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CoverCell");
        public static readonly UINib Nib;

        static CoverCell()
        {
            Nib = UINib.FromName("CoverCell", NSBundle.MainBundle);
        }

        protected CoverCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public void SetCoverImage(UIImage image)
        {
            this.CoverImage.Image = image;
        }
    }
}
