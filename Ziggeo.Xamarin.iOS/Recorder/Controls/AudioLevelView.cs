using Foundation;
using System;
using UIKit;
using System.ComponentModel;
using CoreFoundation;

namespace Ziggeo
{
    [DesignTimeVisible(true)]
    public partial class AudioLevelView : UIView, IComponent
    {
        private double m_audioLevel = 0;
        private double m_currentLevel = 0;

        public AudioLevelView (IntPtr handle) : base (handle)
        {
        }

        public ISite Site { get; set; }

        public event EventHandler Disposed;

        [Export("AudioLevel"), Browsable(true)]
        public double AudioLevel
        {
            get
            {
                return m_audioLevel;
            }
            set
            {
                m_currentLevel = value;
                UpdateLevel();
            }
        }

        private void UpdateLevel()
        {
            if(m_currentLevel > m_audioLevel)
            {
                m_audioLevel = m_currentLevel;
            }
            else
            {
                m_audioLevel -= 0.05;
                if (m_audioLevel < 0) m_audioLevel = 0;
            }
            DispatchQueue.MainQueue.DispatchAsync(() =>
            {
                widthConstraint.Constant = (nfloat)(-contentView.Bounds.Size.Width * (1 - m_audioLevel));
            });
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            if ((Site != null) && Site.DesignMode)
            {
                // Bundle resources aren't available in DesignMode
                return;
            }

            NSBundle.MainBundle.LoadNib("AudioLevelView", this, null);

            // At this point all of the code-behind properties should be set, specifically rootView which must be added as a subview of this view

            this.AddSubview(this.contentView);
            contentView.Frame = this.Bounds;
            contentView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
        }
    }
}