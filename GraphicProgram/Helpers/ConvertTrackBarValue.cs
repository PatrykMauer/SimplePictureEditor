using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicProgram
{
    public static class ConvertTrackBarValue
    {
        public static double ConvertTrackBarValues(int value)
        {
            return value / 100;
        }
    }
}
