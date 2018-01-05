using System;
using System.Collections.Generic;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Randomizer();
            var printer = new Printer();
            ConsoleKeyInfo pressKey;


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

            printer.PrintHelpText();
            pressKey = Console.ReadKey();

            if (pressKey.Key == ConsoleKey.I)
            {
                printer.WhoStartsCheckinPrinter(random, classmates);
            }
            else if (pressKey.Key == ConsoleKey.O)
            {
                printer.WhoStartsCheckoutPrinter(random, classmates);
            }
            else
            {
                printer.PrintHelpText();
            }

            Console.ReadKey();
        }
    }
}

