using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
     public abstract class Shape
    {

        protected double Dimension1 { get; }
        protected double Dimension2 { get; }

        

        public Shape() { }

        public Shape(double Dim1, double Dim2)
        {
            Dimension1 = Dim1;
            Dimension2 = Dim2;
        }

        public abstract double CalculateArea();

    }
}
