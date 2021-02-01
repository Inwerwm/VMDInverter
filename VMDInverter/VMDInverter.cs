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
            List<IVocaloidFrame> allFrames = vmd.Frames;

            var maxTime = allFrames.Max(frame => frame.Frame);

            foreach (var frame in allFrames)
            {
                frame.Frame = maxTime - frame.Frame;
            }
        }
    }
}
