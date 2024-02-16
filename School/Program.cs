using School.Models;

namespace School
{
    internal class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            // add n elements to the list of person

            string[] lines = File.ReadAllLines("data.txt");

            foreach (string line in lines)
            {
                var lineItems = line.Split(',');

                var person = new Person();

                person.FirstName = lineItems[0];
                person.LastName = lineItems[1];
                person.DOB = DateTime.Parse(lineItems[2]);

                people.Add(person);
            }

            Console.WriteLine(people.Count);
        }
    }
}
