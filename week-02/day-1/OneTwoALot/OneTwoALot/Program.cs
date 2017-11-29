using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Give me a number and press enter! ");
            double number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Not enough!");
            }
            else if (number == 1)
            {
                Console.WriteLine("One!");
            }
            else if (number == 2)
            {
                Console.WriteLine("Two!");
            }
            else
            {
                Console.WriteLine("A lot!");

            }
            Console.ReadKey();
        }
    }
}
