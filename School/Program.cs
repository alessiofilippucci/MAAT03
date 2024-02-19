using School.Models;
using School.Processors;

namespace School
{
    internal class Program
    {
        static List<Teacher> teachers = new List<Teacher>();
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            //Teacher t = new Teacher();
            //t.FirstName = "";
            //t.LastName = "";
            //t.Materia = "";
            //t.Speech();
            //Student s = new Student();
            //s.FirstName = "";
            //s.LastName = "";
            //s.CodiceFiscale = "";
            //s.Math = 6;
            //s.Ita = 6;

            SeedProcessor sp = new SeedProcessor();

            if (sp.ProcessSchool(ref teachers, ref students, out Exception ex))
            {
                foreach (Teacher teacher in teachers)
                {
                    teacher.Speech();
                }

                foreach (Student student in students)
                {
                    student.Speech();
                }
            }

        }
    }
}
