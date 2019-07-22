using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(double dim1) : base(dim1, dim1)
        {
        }

        public override double CalculateArea() => 3.14 * Dimension1 * Dimension1;
    }
}
