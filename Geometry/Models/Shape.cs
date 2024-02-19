namespace Geometry.Models
{
    public abstract class Shape : IShape
    {
        public virtual double Area()
        {
            return 0;
        }

        public string GetValue()
        {
            return "Pippo";
        }

        public virtual double Perimeter()
        {
            return 0;
        }
    }
}
