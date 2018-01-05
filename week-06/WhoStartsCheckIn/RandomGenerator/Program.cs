using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Randomizer();
            var control = new Control();                
            
            var classmates = new List<Classmates>
            {
                new Classmates("Zsuzska"),
                new Classmates("David"),
                new Classmates("Mark"),
                new Classmates("Misi"),
                new Classmates("Dani"),
                new Classmates("Eszter"),
                new Classmates("Nyina"),
                new Classmates("Tamas"),
                new Classmates("Marci"),
                new Classmates("Szilard"),
                new Classmates("Szabolcs"),
                new Classmates("Anett"),
                new Classmates("Balint"),
                new Classmates("Nori"),
                new Classmates("Andras")
            };

            control.StartProgram(random, classmates);                    
                       
            Console.ReadKey();
        }
    }
}

