using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \t What is your name farmer?");
            string name = Console.ReadLine();

            Console.WriteLine("\n \t How many chickens have you got {0} ?", name);
            int chickens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n \t And how many pigs ? ");
            int pigs = Convert.ToInt32(Console.ReadLine());

            int legs = chickens * 2 + pigs * 4;

            Console.WriteLine("\n \t Then your animals have {0} legs alltogether {1} !!! ", legs, name);
            Console.ReadKey();
        }
    }
}