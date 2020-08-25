using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Homework
{
    public class FizzBuzz
    {
        private readonly int fizzer;
        private readonly int buzzer;

        public FizzBuzz(int fizzer = 3, int buzzer = 5)
        {
            this.fizzer = fizzer;
            this.buzzer = buzzer;
        }
        public string Read(int num) {
            if (num <= 0)
                throw new ArgumentOutOfRangeException("Try again with a positive number!");

            bool divisibleByFizzer = num % fizzer == 0;
            bool divisibleByBuzzer = num % buzzer == 0;

            if (divisibleByFizzer && divisibleByBuzzer)
                return "fizzbuzz";
            if (divisibleByFizzer)
                return "fizz";
            if (divisibleByBuzzer)
                return "buzz";
            return num.ToString();
        }
    }
}
