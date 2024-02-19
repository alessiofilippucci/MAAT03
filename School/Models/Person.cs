namespace School.Models
{
    internal abstract class Person
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

        public virtual void Speech()
        {
            Console.WriteLine("Hello!");
        }
    }
}
