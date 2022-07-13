using Foundation;
using System;
using UIKit;
using System.ComponentModel;
using CoreFoundation;

namespace Ziggeo
{
    public partial class LuxMeterView : UIView, IComponent
    {

        public LuxMeterView (IntPtr handle) : base (handle)
        {
        }

        public ISite Site { get; set; }

        public event EventHandler Disposed;

        [Export("Luminosity"), Browsable(true)]
        public double Luminosity
        {
            get;
            set;
        }

        private void UpdateImage()
        {
            if (this.Window != null)
            {
                if (Luminosity < -0.5)
                {
                    imageView.Image = ImageLoader.GetImageFromResource("sun-50_red");
                    imageView.Hidden = !imageView.Hidden;
                }
                else if (Luminosity < 1)
                {
                    imageView.Image = ImageLoader.GetImageFromResource("sun-50_yellow");
                    imageView.Hidden = !imageView.Hidden;
                }
                else
                {
                    imageView.Image = ImageLoader.GetImageFromResource("sun-50");
                    imageView.Hidden = false;
                }
            }
            DispatchQueue.MainQueue.DispatchAfter(new DispatchTime(DispatchTime.Now, TimeSpan.FromSeconds(0.5)), UpdateImage);
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            if ((Site != null) && Site.DesignMode)
            {
                // Bundle resources aren't available in DesignMode
                return;
            }

            NSBundle.MainBundle.LoadNib("LuxMeterView", this, null);

            // At this point all of the code-behind properties should be set, specifically rootView which must be added as a subview of this view

            this.AddSubview(this.contentView);
            contentView.Frame = this.Bounds;
            contentView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
            DispatchQueue.MainQueue.DispatchAfter(new DispatchTime(DispatchTime.Now, TimeSpan.FromSeconds(0.5)), UpdateImage);
        }
    }
}