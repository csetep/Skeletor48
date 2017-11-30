using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] toPrint = { "Print", "this", "text", "for", "me", "!" };
            Printer(toPrint);
            Console.ReadLine();
        }
        static void Printer(string[] textToPrint)
        {

            foreach (string words in textToPrint)
                Console.WriteLine(words);

        }
    }
}
