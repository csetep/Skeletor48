using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrg
{
    class Mentor : Person
    {
        public string Level { get; set; }

        public Mentor(string name, int age, string gender, string level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }

        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, Level);
        }
    }
}
