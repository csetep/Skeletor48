using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class Sponsor : Person
    {
        public string Company { get; set; }
        public int hiredStudents { get; set; }

        public Sponsor(string name, int age, string gender, string company)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Company = company;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, Company, hiredStudents);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }
    }
}