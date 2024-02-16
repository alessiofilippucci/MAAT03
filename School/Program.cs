using School.Models;

namespace School
{
    internal class Program
    {
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            // add n elements to the list of person from file
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

            // spostare procedura di lettura da file
            // e parsing in classe Persona
            // in un'altra/e classe/i

            Console.WriteLine(people.Count);
        }
    }
}
