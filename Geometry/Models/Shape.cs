namespace Geometry.Models
{
    public abstract class Shape
    {
        public virtual double Area()
        {
            return 0;
        }

        public virtual double Perimeter()
        {
            return 0;
        }
    }
}
