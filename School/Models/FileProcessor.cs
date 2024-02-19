namespace School.Models
{
    internal class FileProcessor
    {
        private string _fullPath;

        public FileProcessor(string fullPath)
        {
            if (!File.Exists(fullPath))
                throw new FileNotFoundException();

            _fullPath = fullPath;
        }

        public bool ProcessPeople(ref List<Person> people, out Exception exception, char sep = ',')
        {
            exception = null;

            try
            {
                string[] lines = File.ReadAllLines(_fullPath);

                foreach (string line in lines)
                {
                    string[] lineItems = line.Split(sep);

                    var person = new Person();

                    person.FirstName = lineItems[0];
                    person.LastName = lineItems[1];
                    person.DOB = DateTime.Parse(lineItems[2]);

                    people.Add(person);
                }

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
