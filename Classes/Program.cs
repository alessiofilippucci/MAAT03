namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("AAAA");

            Calcolatrice c = new Calcolatrice(10, 80);
            Calcolatrice c1 = c;

            c.result = 100;
            c1.result = 20000;

            Console.WriteLine(c.result);
            Console.WriteLine(c1.result);

            //c.Somma(true);
            //c.Differenza();
            //c.Moltiplicazione();
            //c.Divisione(true);
        }
    }
}
