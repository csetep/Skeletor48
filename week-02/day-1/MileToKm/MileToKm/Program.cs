using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n \t What is your name my human friend?");
            string name = Console.ReadLine();

            Console.WriteLine("\n \t Give me the number of kilometers and I will convert it to miles for You {0}!", name);
            int km = Convert.ToInt32(Console.ReadLine());

            double mile = km / 1.609344;

            Console.WriteLine("\n \t {0} kilometers is {1} miles dear {2}!", km, mile, name);
            Console.ReadKey();
        }
    }
}
