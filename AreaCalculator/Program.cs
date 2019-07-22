using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Circle(10);
            Console.WriteLine($"Area of circle is {s.CalculateArea()}");
            s = new Rectangle(10, 20);
            Console.WriteLine($"Area of Rectangle is {s.CalculateArea()}");
            s = new Square(10);
            Console.WriteLine($"Area of square is {s.CalculateArea()}");
            s = new Triangle(10, 20);
            Console.WriteLine($"Area of Triangle is {s.CalculateArea()}");
            Console.ReadKey(true);
        }
    }
}
