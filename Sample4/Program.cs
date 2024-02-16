namespace Sample4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            p.FirstName = "Test";
            Console.WriteLine(p.FirstName);

            //string firstName = p.GetFirstName();

            //p.SetFirstName("xxxx");
        }
    }
}
