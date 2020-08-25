using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Homework
{
    public class Random
    {
        public static int GenerateNumber(int low, int high) {
            //if (high < low)
            //    throw new InvalidOperationException("Numbers are not ordered!");

            return new System.Random().Next(low, high);
        }
    }
}
