using MindboxTestTask;
using NUnit.Framework;

namespace MaindboxTestTask.Tests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        [TestCase(5,78.5)]
        [TestCase(6, 113.04)]
        [TestCase(8, 200.96)]
        [TestCase(10, 314)]
        public void CalculateSquare_CorrectData_CorrectSquare(double radius,double expectedSquare)
        {
            Circle circle = new Circle(radius);

            var calcSquare = circle.CalculateSquare();

            Assert.That(calcSquare, Is.EqualTo(expectedSquare));
        }
    }
}