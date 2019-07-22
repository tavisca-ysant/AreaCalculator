namespace AreaCalculator
{
    public class Triangle : Shape
    {
        public Triangle(double dim1, double dim2) : base(dim1, dim2)
        {
        }

        public override double CalculateArea() => 0.5 * Dimension1 * Dimension2;
    }
}