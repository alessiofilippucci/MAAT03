namespace School.Models
{
    internal class Teacher : Person
    {
        public string Materia { get; set; }

        public string Explain()
        {
            return ".....";
        }

        public override void Speech()
        {
            base.Speech();
            Console.WriteLine("I'm a teacher");
        }
    }
}
