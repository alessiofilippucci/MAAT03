using School.Models;

namespace School
{
    internal class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            FileProcessor fp = new FileProcessor("data.txt");
            fp.ProcessPeoples(ref people);

            Console.WriteLine(people.Count);
        }
    }
}
