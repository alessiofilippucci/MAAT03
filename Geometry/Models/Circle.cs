namespace Geometry.Models
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }

        public void TestCircle()
        {
            Console.WriteLine("I'm a circle");
        }
    }
}
