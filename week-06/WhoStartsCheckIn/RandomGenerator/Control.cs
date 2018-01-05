using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    public class Control
    {
        Printer printer = new Printer();
        ConsoleKeyInfo pressKey;

        public void StartProgram(Randomizer random, List<Classmates> classmate)
        {
            printer.PrintHelpText();
            SelectorMethod(random, classmate);
        }

        public void SelectorMethod(Randomizer random, List<Classmates> classmates)
        {
            pressKey = Console.ReadKey();

            if (pressKey.Key == ConsoleKey.I)
            {
                printer.WhoStartsCheckinPrinter(random, classmates);
            }
            else if (pressKey.Key == ConsoleKey.O)
            {
                printer.WhoStartsCheckoutPrinter(random, classmates);
            }
            else if (pressKey.Key == ConsoleKey.E)
            {
                return;
            }
            else
            {
                StartProgram(random, classmates);
            }
        }
    }
}
