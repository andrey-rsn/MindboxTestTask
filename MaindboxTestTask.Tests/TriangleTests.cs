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
    }
}
