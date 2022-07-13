using Foundation;
using System;
using UIKit;
using System.ComponentModel;
using CoreFoundation;
using CoreGraphics;
using System.Collections.Generic;
using System.Linq;

namespace Ziggeo
{
    [Register("FaceOutlineView")]
    [DesignTimeVisible(true)]
    public class FaceOutlineView : UIView
    {
        private class Face
        {
            public double Alpha { get; set; }
            public int FaceID { get; set; }
            public CGRect Rect { get; set; }
            public int FaceVisible { get; set; }
        }

        private Dictionary<int, Face> m_faces;

        public FaceOutlineView(IntPtr p) : base(p)
        {
        }

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            if (m_faces != null)
            {
                foreach (var face in m_faces.Values.ToArray())
                {
                    CGRect faceRect = face.Rect;
                    UIBezierPath rectPath = new UIBezierPath();
                    rectPath.MoveTo(faceRect.Location);
                    //[rectPath moveToPoint:faceRect.origin];
                    //[rectPath addLineToPoint:CGPointMake(faceRect.origin.x + faceRect.size.width, faceRect.origin.y)];
                    rectPath.AddLineTo(new CGPoint(faceRect.Location.X + faceRect.Size.Width, faceRect.Location.Y));
                    //[rectPath addLineToPoint:CGPointMake(faceRect.origin.x + faceRect.size.width, faceRect.origin.y + faceRect.size.height)];
                    rectPath.AddLineTo(new CGPoint(faceRect.Location.X + faceRect.Size.Width, faceRect.Location.Y + faceRect.Size.Height));
                    //[rectPath addLineToPoint:CGPointMake(faceRect.origin.x, faceRect.origin.y + faceRect.size.height)];
                    rectPath.AddLineTo(new CGPoint(faceRect.Location.X, faceRect.Location.Y + faceRect.Size.Height));
                    //[rectPath addLineToPoint:faceRect.origin];
                    rectPath.AddLineTo(faceRect.Location);
                    //[[[UIColor alloc] initWithRed:1 green:1 blue:0 alpha:face.alpha] set];
                    new UIColor(1, 1, 0, (nfloat)face.Alpha).SetColor();
                    //[rectPath stroke];
                    rectPath.Stroke();

                    face.Alpha -= 0.05;
                    face.FaceVisible -= 1;
                    if (face.Alpha <= 0)
                    {
                        face.Alpha = 0;
                    }
                    if (face.FaceVisible < 0)
                    {
                        m_faces.Remove(face.FaceID);
                    }
                }
            }
        }

        public void AddFace(int faceID, CGRect rect)
        {
            if (m_faces == null) m_faces = new Dictionary<int, Face>();
            Face face;
            if(!m_faces.TryGetValue(faceID, out face))
            {
                face = new Face();
                m_faces[faceID] = face;
                face.Alpha = 1;
            }
            face.FaceID = faceID;
            face.Rect = rect;
            face.FaceVisible = 25;
        }
    }
}
