using Bogus;

namespace School.Models
{
    internal class SeedProcessor
    {
        public SeedProcessor()
        {
        }

        public bool ProcessPeople(ref List<Person> people, out Exception exception, char sep = ',')
        {
            exception = null;

            try
            {
                PersonSeed ps = new PersonSeed();
                List<Person> data = ps.Generate(1000);
                people.AddRange(data);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
    }
}
