using DayanSamples.Math;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Tests.Unit.Math
{
    [TestFixture]
    [Ignore("For later use ...")]
    public class MathematicsTests
    {
        Mathematics math;

        [SetUp]
        public void Setup() { 
           math  = new Mathematics();
        }

        [Test]
        [TestCase(1,4,5)]
        [TestCase(10,40,50)]
        [TestCase(1000,2000,3000)]
        [TestCase(1,40,41)]
        [TestCase(-1,1000,0)]
        public void Add_Always_ReturnsSumOfAandB(int a, int b, int expected) {
            // Arrange
            
            // Act
            var sum = math.Add(a, b);

            // Assert
            //Assert.That(sum, Is.EqualTo(expected));
            Assert.AreEqual(expected, sum);
        }
        [Test]
        public void Add_For1And2_Returns3()
        {
            // Arrange
            int expected = 3;

            // Act
            var sum = math.Add(1, 2);

            // Assert
            //Assert.That(sum, Is.EqualTo(expected));
            Assert.AreEqual(expected, sum);
        }
    }
}
