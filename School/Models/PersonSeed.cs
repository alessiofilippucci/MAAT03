using Bogus;

namespace School.Models
{
    internal class PersonSeed : Faker<Person>
    {
        public PersonSeed()
        {
            RuleFor(d => d.FirstName, f => f.Person.FirstName);
            RuleFor(d => d.LastName, f => f.Person.LastName);
            RuleFor(d => d.DOB, f => f.Person.DateOfBirth);
        }
    }
}
