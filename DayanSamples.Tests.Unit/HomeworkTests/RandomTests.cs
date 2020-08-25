using DayanSamples.Homework;
using NUnit.Framework;

namespace DayanSamples.Tests.Unit.HomeworkTests
{

    [TestFixture]
    public class RandomTests
    {
        [Test]
        public void GenerateNumber_Always_ReturnsInRange() {
            //Arrange
            //Act
            var result = Random.GenerateNumber(2,4);
            //Assert
            Assert.That(result, Is.GreaterThanOrEqualTo(2).
                                And.LessThanOrEqualTo(4));
        }
        [Test]
        public void GenerateNumber_WhenHighIsLessThanLow_ThrowsException()
        {
            //Arrange
            //Act
            //Assert
            Assert.Catch(() => Random.GenerateNumber(2, 1));
        }
    }
}
