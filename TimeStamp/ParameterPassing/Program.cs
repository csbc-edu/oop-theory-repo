using System;

namespace ParameterPassing
{
    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }

    class Program
    {
        static void Enroll(Student student)
        {
            student.Enrolled = true; // This changes the student variable that was passed in outside of the method.
            student = new Student(); // This does not change the student variable outside of the method but creates a new reference. Since student now points to a new reference, the student variable outside of the method is no longer affected after this line.
            student.Enrolled = false; // This changes the local student inside the method.
        }

        static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "Susan",
                Enrolled = false
            };

            Enroll(student);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Enrolled);
        }
    }
}
