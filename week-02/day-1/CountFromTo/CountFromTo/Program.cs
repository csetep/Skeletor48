using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tGive me two numbers and then press Enter!");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number2 <= number1)
            {
                Console.WriteLine("\tThe second number should be bigger!");
            }
            else
            {
                for (int i = number1; i < number2; i++)
                {
                    Console.WriteLine("\n\t{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
