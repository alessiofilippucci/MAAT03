using Bogus;
using School.Models;

namespace School.SeederModels
{
    internal class StudentSeed : Faker<Student>
    {
        public StudentSeed()
        {
            RuleFor(d => d.FirstName, f => f.Person.FirstName);
            RuleFor(d => d.LastName, f => f.Person.LastName);
            RuleFor(d => d.DOB, f => f.Person.DateOfBirth);
        }
    }
}
