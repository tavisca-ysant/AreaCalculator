namespace AreaCalculator
{
    public class Triangle : Shape
    {
        private static readonly double _half = 3.14;
        public Triangle(double dim1, double dim2) : base(dim1, dim2)
        {
        }

        public override double CalculateArea() => _half * Dimension1 * Dimension2;
    }
}