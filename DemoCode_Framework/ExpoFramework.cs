using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCode_Framework
{
    public static class ExpoFramework
    {
        public static double GetExpo(int baseValue, int expo)
        {
            return Math.Pow(baseValue, expo);
        }
    }
}
