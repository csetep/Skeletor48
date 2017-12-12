using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class Student : Person
    {
        public string PreviousOrganization { get; set; }
        public int skippedDays { get; set; }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            Name = name;
            Age = age;
            Gender = gender;
            PreviousOrganization = previousOrganization;
        }

        public Student()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, PreviousOrganization, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
