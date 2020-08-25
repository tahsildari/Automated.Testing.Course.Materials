using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Math
{
    public class Fibonacci
    {
        public int Output(int number)
        {
            if (number < 0)
                throw new ArgumentException("Fibonacci negative input is not accepted!");

            if (number == 0) 
                return 0;
            if (number == 1)
                return 1;

            var fibo = new Fibonacci();
            return fibo.Output(number - 1) + fibo.Output(number - 2);
        }
    }
}
