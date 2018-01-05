using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer random = new Randomizer();

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

            Console.WriteLine("\n\n\n\n\n \t\t\t\t Dear {0} ! " +
                "\n\t\t\t You start the check-in today!" + "\n\n\n\t\t\t"+
                      @"           ..(\ /)
                                   ..('.')  
                                    c(“)(“)"
                , random.RandomizerMethod(classmates));

            Console.ReadKey();
        }
    }
}

