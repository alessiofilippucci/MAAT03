using School.Models;

namespace School
{
    internal class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            //FileProcessor fp = new FileProcessor("data.txt");
            
            //if(fp.ProcessPeople(ref people, out Exception ex))
            //    Console.WriteLine(people.Count);
            //else
            //    Console.WriteLine(ex.Message);

            SeedProcessor sp = new SeedProcessor();
            if (sp.ProcessPeople(ref people, out Exception ex))
                Console.WriteLine(people.Count);
            else
                Console.WriteLine(ex.Message);
        }
    }
}
