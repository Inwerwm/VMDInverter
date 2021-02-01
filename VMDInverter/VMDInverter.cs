using MikuMikuMethods;
using MikuMikuMethods.VMD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMDInverter
{
    static class VMDInverter
    {
        public static void ReverseTime(VocaloidMotionData vmd)
        {
            List<IVocaloidFrame> allFrames = vmd.Frames;

            var maxTime = allFrames.Max(frame => frame.Frame);

            foreach (var frame in allFrames)
            {
                frame.Frame = maxTime - frame.Frame;
            }
        }

        public static void ReverseInterpolation(VocaloidMotionData vmd)
        {
            foreach (var pair in vmd.CameraFrames.SelectMany(frame => frame.InterpolationCurves))
            {
                ReverseInterpolation(pair.Value);
            }
        }

        private static void ReverseInterpolation(InterpolationCurve curve)
        {
            var bytes = curve.ToBytes().Select(b=> (byte)(0x7F - b)).ToArray();
            curve.EarlyControlePoint = (bytes[2], bytes[3]);
            curve.LateControlePoint = (bytes[0], bytes[1]);
        }
    }
}
