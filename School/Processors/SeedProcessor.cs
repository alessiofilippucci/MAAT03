using School.Models;
using School.SeederModels;

namespace School.Processors
{
    internal class SeedProcessor
    {
        public SeedProcessor()
        {
        }

        public bool ProcessPeople(ref List<Person> people, out Exception exception)
        {
            exception = null;

            try
            {
                List<Person> personData = new PersonSeed().Generate(1000);
                people.AddRange(personData);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }


        public bool ProcessSchool(ref List<Teacher> teachers, ref List<Student> students, out Exception exception)
        {
            exception = null;

            try
            {
                List<Teacher> teacherData = new TeacherSeed().Generate(2);
                teachers.AddRange(teacherData);
                List<Student> studentData = new StudentSeed().Generate(30);
                students.AddRange(studentData);
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
