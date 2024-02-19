using Bogus;
using School.Models;

namespace School.SeederModels
{
    internal class PersonSeed : Faker<Models.Person>
    {
        public PersonSeed()
        {
            RuleFor(d => d.FirstName, f => f.Person.FirstName);
            RuleFor(d => d.LastName, f => f.Person.LastName);
            RuleFor(d => d.DOB, f => f.Person.DateOfBirth);
        }
    }
}
