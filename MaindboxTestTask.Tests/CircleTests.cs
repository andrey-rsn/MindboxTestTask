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

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-100)]
        public void Constructor_IncorrectData_ArgumentException (double radius)
        {

            Assert.That(() => { Circle circle = new Circle(radius); }, Throws.ArgumentException);
        }

        [Test]
        [TestCase(1)]
        [TestCase(20)]
        [TestCase(100)]
        
        public void Constructor_CorrectData_CreatedInstance(double radius)
        {
            Circle circle = new Circle(radius);

            var expectedRadius = radius;

            Assert.That(circle.Radius, Is.EqualTo(expectedRadius));
        }
    }
}