using DayanSamples.Homework;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DayanSamples.Tests.Unit.HomeworkTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz sut;

        [SetUp]
        public void Setup() {
            sut = new FizzBuzz();
        }

        [Test]
        public void Read_ForNumbersNotDivisableTo3Or5_RetunrsSameNumber() {
            //Arrange
            //Act
            var result = sut.Read(4);
            //Assert
            Assert.AreEqual("4", result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void Read_WhenDividableBy3_ReturnsFizz(int num) {
            //Arrange
            //Act
            var echo = sut.Read(num);
            //Assert
            Assert.AreEqual("fizz", echo);
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(5555)]
        public void Read_WhenDividableBy5_ReturnsFizz(int num)
        {
            //Arrange
            //Act
            var echo = sut.Read(num);
            //Assert
            Assert.AreEqual("buzz", echo);
        }

        [Test]
        [TestCase(15)]
        [TestCase(30)]
        public void Read_WhenDividableByBoth3And5_ReturnsFizzBuzz(int num)
        {
            //Arrange
            //Act
            var echo = sut.Read(num);
            //Assert
            Assert.AreEqual("fizzbuzz", echo);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-1000)]
        public void Read_WhenNumberIsZeroOrNegative_ThrowsException(int num)
        { 
            //Arrange
            //Act
            //Assert
            Assert.Catch(()=>sut.Read(num));
        }

        [Test]
        public void Read_For2And7_ReturnsProperValues()
        {
            //Arrange
            var anotherSut = new FizzBuzz(2, 7);
            //Act
            var fizz = anotherSut.Read(4);
            var buzz = anotherSut.Read(7);
            var fizzbuzz = anotherSut.Read(2*7*3);
            //Assert
            Assert.That(fizz, Is.EqualTo("fizz"));
            Assert.AreEqual("buzz", buzz);
            Assert.True(fizzbuzz == "fizzbuzz");
        }
    }
}
