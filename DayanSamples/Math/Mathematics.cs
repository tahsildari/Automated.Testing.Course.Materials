using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Math
{
    public class Mathematics
    {
        public int Add(int a, int b) {
            if (a < 0 || b < 0)
                return 0;
            return a + b;
        }
    }
}
