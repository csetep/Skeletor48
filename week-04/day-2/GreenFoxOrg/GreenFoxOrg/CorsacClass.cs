using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class CorsacClass : Person
    {
        public string ClassName { get; set; }
        List<Student> studentsList = new List<Student>();
        List<Mentor> mentorsList = new List<Mentor>();

        public CorsacClass(string className)
        {
            ClassName = className;

        }

        public void AddStudent(Student student)
        {
            studentsList.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentorsList.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Corsac {0} class has {1} students and {2} mentors.", ClassName, studentsList.Count, mentorsList.Count);
        }
    }
}
