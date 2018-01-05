using System;
using System.Collections.Generic;
using System.Text;

namespace RandomGenerator
{
    class Printer
    {
        public void PrintHelpText()
        {
            Console.WriteLine(
                           "\n\t   Command Line CheckIn/Out Randomizer application"
                            + "\n================================================================================"
                            + "\n\t   Choose an option:"
                            + "\n\t   Press 'I' To Decide Who Starts the CheckIn!"
                            + "\n\t   Press 'O' To Decide Who Starts the CheckOut!"                          
                            + "\n================================================================================"
                            );
        }

        public void WhoStartsCheckinPrinter(Randomizer random, List<Classmates> classmates)
        {
            Console.WriteLine("\n\n\n \t\t\t\t Dear {0} ! " +
                "\n\t\t\t You start the checkIN today!" + "\n\n\n\t\t\t" +
                      @"           ..(\ /)
                                   ..('.')  
                                    c(“)(“)"
                , random.RandomizerMethod(classmates));
        }

        public void WhoStartsCheckoutPrinter(Randomizer random, List<Classmates> classmates)
        {
            Console.WriteLine("\n\n\n \t\t\t\t Dear {0} ! " +
                "\n\t\t\t You start the checkOUT today!" + "\n\n\n\t\t\t" +
                      @"           ..(\'/)
                                   ..(-.-)  
                                    c(“)(“)...zzzz"
                , random.RandomizerMethod(classmates));
        }
    }
}

