namespace Classes
{
    internal class Persona
    {
        public string firstName;
        public string lastName;
        public int age;

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
