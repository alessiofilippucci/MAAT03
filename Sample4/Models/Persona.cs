namespace Sample4
{
    internal class Persona
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Persona()
        {
        }

        public Persona(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new Exception("Missing param 'firstName'");

            this.firstName = firstName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"Il tuo nome completo è: {firstName} {lastName}");
        }

        public void PrintAge()
        {
            Console.WriteLine($"La tua età è: {age}");
        }
    }
}
