namespace School.Models
{
    internal class Student : Person
    {
        public double Math { get; set; }
        public double Ita { get; set; }

        public void DoHomework()
        {

        }

        public override void Speech()
        {
            base.Speech();
            Console.WriteLine("I'm a student");
        }
    }
}
