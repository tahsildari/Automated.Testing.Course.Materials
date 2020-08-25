using DayanSamples.Homework;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayanSamples.Tests.Unit.HomeworkTests
{
    [TestFixture]
    public class NumberTests
    {
        // System Under Test
        private Number sut;

        [SetUp]
        public void Setup()
        {
            sut = new Number();
        }

        // Odd numbers

        [Test]
        public void IsOdd_For1_ReturnsTrue() {
            //Arrange
            //Act
            var result = sut.IsOdd(1);
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsOdd_For17_ReturnsTrue()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(17);
            //Assert
            Assert.AreEqual(true, result);
        }

        // Even numbers

        [Test]
        public void IsOdd_For4_ReturnsFalse()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(4);
            //Assert
            Assert.AreEqual(false, result);
        }


        [Test]
        public void IsOdd_For0_ReturnsFalse()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(0);
            //Assert
            Assert.AreEqual(false, result);
        }

        // Negative numbers

        [Test]
        public void IsOdd_ForMinus1_ReturnsTrue()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(-1);
            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsOdd_ForMinus2_ReturnsFalse()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(-2);
            //Assert
            Assert.AreEqual(false, result);
        }


        [Test]
        public void IsOdd_ForMinus19_ReturnsTrue()
        {
            //Arrange
            //Act
            var result = sut.IsOdd(-19);
            //Assert
            Assert.AreEqual(true, result);
        }


    }
}
