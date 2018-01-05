using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    public class Randomizer
    {
        Random random = new Random();

        public string RandomizerMethod(List<Classmates> classmates)
        {
            return classmates[random.Next(0, 15)].Name;
        }
    }
}
