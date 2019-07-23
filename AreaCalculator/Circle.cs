using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        private static readonly double _pi = 3.14;
        public Circle()
        {
        }

        public Circle(double dim1) : base(dim1, dim1)
        {
        }

        public override double CalculateArea() => _pi * Dimension1 * Dimension1;
    }
}
