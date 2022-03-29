using MindboxTestTask;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaindboxTestTask.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [TestCase(5,6,7,14.7)]
        [TestCase(2, 3, 4, 2.9)]

        public void CalculateSquare_CorrectData_CorrectSquare(double a,double b, double c,double expectedSquare)
        {
            Triangle triangle = new Triangle(a, b, c);

            var CalculatedSquare = triangle.CalculateSquare();

            Assert.That(CalculatedSquare, Is.EqualTo(expectedSquare));
        }

        [Test]
        [TestCase(0,1,2)]
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, 3)]
        public void Constructor_IncorrectData_ArgumentException(double a, double b, double c)
        {
            Assert.That(() => { Triangle triangle = new Triangle(a, b, c); },Throws.ArgumentException);
        }

        [Test]
        [TestCase(2, 3, 4)]
        [TestCase(4, 6, 7)]
        [TestCase(7, 8, 9)]
        public void Constructor_CorrectData_CreatedInstance(double a, double b, double c)
        {
            Triangle triangle=new Triangle(a, b, c);

            var expectedA = a;
            var expectedB = b; 
            var expectedC = c;

            Assert.That(triangle.A,Is.EqualTo(expectedA));
            Assert.That(triangle.B, Is.EqualTo(expectedB));
            Assert.That(triangle.C, Is.EqualTo(expectedC));
        }
    }
}
