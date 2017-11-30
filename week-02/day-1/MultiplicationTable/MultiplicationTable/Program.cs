using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\tEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 10)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int multiplication = i * number;
                    Console.WriteLine("\t{0} * {1} = {2}", i, number, multiplication);
                }
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    int multiplication = i * number;
                    Console.WriteLine("\t{0} * {1} = {2}", i, number, multiplication);
                }
            }

            Console.ReadKey();
        }
    }
}
