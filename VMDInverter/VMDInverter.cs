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
        public static void Do(VocaloidMotionData vmd)
        {
            List<IVocaloidFrame> allFrames = new();
            allFrames.AddRange(vmd.CameraFrames);
            allFrames.AddRange(vmd.LightFrames);
            allFrames.AddRange(vmd.MorphFrames);
            allFrames.AddRange(vmd.MotionFrames);
            allFrames.AddRange(vmd.PropertyFrames);
            allFrames.AddRange(vmd.ShadowFrames);

            var maxTime = allFrames.Max(frame => frame.Frame);

            foreach (var frame in allFrames)
            {
                frame.Frame = maxTime - frame.Frame;
            }
        }
    }
}
