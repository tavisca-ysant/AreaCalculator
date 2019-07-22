using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Rectangle : Shape
    {
        public Rectangle(double dim1, double dim2) : base(dim1, dim2)
        {
        }

        public override double CalculateArea() => Dimension1 * Dimension2;
    }
}
