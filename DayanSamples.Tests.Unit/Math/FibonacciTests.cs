using DayanSamples.Math;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Tests.Unit.Math
{
    [TestFixture]
    [Ignore("For later use ...")]
    [Category("Simple")]

    public class FibonacciTests
    {
        [Test]
        public void Output_ForZero_ReturnsZero() {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act
            var output = fibo.Output(0);

            //Assert
            Assert.AreEqual(0, output);
        }

        [Test]
        public void Output_ForOne_ReturnsOne()
        {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act
            var output = fibo.Output(1);

            //Assert
            Assert.AreEqual(1, output);
        }


        [Test]
        public void Output_WhenInputIsGreaterThan1_ReturnsSumOf2PreviousFibos()
        {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act
            var output = fibo.Output(4);

            //Assert
            Assert.AreEqual(3, output);
        }

        [Test]
        public void Output_WhenInputIsNegative_ThrowsException()
        {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act

            //Assert
            Assert.Catch(()=> fibo.Output(-1));
        }

        [Test]
        public void Output_WhenInputIsNegative_ThrowsArgumentException()
        {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act

            //Assert
            Assert.Throws<ArgumentException>(()=> fibo.Output(-2));
        }

        [Test]
        public void Output_WhenInputIsNegative_ThrowsExceptionWithProperMessage()
        {
            //Arrange
            Fibonacci fibo = new Fibonacci();

            //Act
            try
            {
                fibo.Output(-1);
            }
            catch (Exception ex)
            {
                //Assert
                StringAssert.Contains("not accept", ex.Message);
                StringAssert.Contains("negative", ex.Message);
            }

        }
    }
}
