namespace School.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DOB.Year;
            }
        }

        // restituire l'età della persona
        // tramite un metodo
        // o una proprietà
        public int GetAge()
        {
            return DateTime.Now.Year - DOB.Year;
        }
    }
}
