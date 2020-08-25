using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Homework
{
    public class Number
    {
        public bool IsOdd(int number) => System.Math.Abs(number % 2) == 1;
    }
}
