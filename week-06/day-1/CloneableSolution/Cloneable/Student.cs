using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class Student : Person, ICloneable
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

        public object Clone()
        {            
            return this.MemberwiseClone();
        }

        public Student GetClone()
        {
            var clone = (Clone() as Student);

            return clone;
        }

        public string GetBasicStudentData()
        {
            return String.Format("{0},{1}, {2},{3}", Name, Age, Gender, PreviousOrganization);
        }
    }
}
