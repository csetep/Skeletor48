using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();

            Student john = new Student("John Doe", 20, "male", "BME");
            Student johnTheClone = john.GetClone();

            student.Add(john);
            student.Add(johnTheClone);

            foreach (Student person in student)
            {
                Console.WriteLine(person.GetBasicStudentData());
            }

            Console.ReadKey();
        }
    }
}
