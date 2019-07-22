using System;
using Xunit;
using AreaCalculator;

namespace AreaCalculator.Tests
{
    public class UnitTest1
    {

        private Shape s;
        [Fact]
        public void TestCircle()
        {
            s = new Circle(10);
            Assert.Equal(314, s.CalculateArea());
        }

        [Fact]
        public void TestSquare()
        {
            s = new Square(10);
            Assert.Equal(100, s.CalculateArea());
        }


        [Fact]
        public void TestRectangle()
        {
            s = new Rectangle(10, 20);
            Assert.Equal(200, s.CalculateArea());
        }

        [Fact]
        public void TestTriangle()
        {
            s = new Triangle(20, 10);
            Assert.Equal(100, s.CalculateArea());
        }



    }
}
