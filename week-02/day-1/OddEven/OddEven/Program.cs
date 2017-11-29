using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Give me a number and press enter! ");
            double number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else
            {
                Console.WriteLine("This number is Odd!");
            }

            Console.ReadKey();
        }
    }
}
