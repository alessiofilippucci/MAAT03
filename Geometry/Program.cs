using Geometry.Models;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle c = new Circle(5.50);
            //Console.WriteLine("Circle");
            //Console.WriteLine("Area: {0}", c.Area());
            //Console.WriteLine("Perimeter: {0}", c.Perimeter());

            //Rectangle r = new Rectangle(10, 50);
            //Console.WriteLine("Rectangle");
            //Console.WriteLine("Area: {0}", r.Area());
            //Console.WriteLine("Perimeter: {0}", r.Perimeter());

            Shape s;

            s = new Circle(5.50);
            Console.WriteLine("Circle");
            Console.WriteLine("Area: {0}", s.Area());
            Console.WriteLine("Perimeter: {0}", s.Perimeter());
            
            ((Circle)s).TestCircle();

            s = new Rectangle(10, 50);
            Console.WriteLine("Rectangle");
            Console.WriteLine("Area: {0}", s.Area());
            Console.WriteLine("Perimeter: {0}", s.Perimeter());

        }
    }
}