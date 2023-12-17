using System;
using CoreGraphics;
using ZiggeoMediaSDK;

namespace Ziggeo
{
    public class SensorCallback : ZiggeoSensorDelegate
    {
        public override void LuxMeter(double luminousity)
        {
            throw new NotImplementedException();
        }

        public override void AudioMeter(double audioLevel)
        {
            throw new NotImplementedException();
        }

        public override void FaceDetected(int faceID, CGRect rect)
        {
            throw new NotImplementedException();
        }
    }
}