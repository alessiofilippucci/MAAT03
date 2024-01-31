namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** CALCOLO AREA CERCHIO ***");
            Console.WriteLine();
            Console.WriteLine("Inserisci il raggio: ");

            double radius = double.Parse(Console.ReadLine());

            double area = GetCircleArea(radius);
            double area2 = GetCircleArea(10);

            Console.WriteLine($"L'area è: {area}");
        }

        static double GetCircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        static double GetCircleArea(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}
