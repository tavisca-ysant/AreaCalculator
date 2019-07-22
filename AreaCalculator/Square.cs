using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : Shape
    {

        public Square(double dimension1) : base(dimension1, dimension1)
        {

        }

        public override double CalculateArea() => Dimension1 * Dimension1;
    }
}
