
using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The factorial of {0}", num);
            Console.WriteLine(Factorio(num));

            Console.ReadLine();

        }
        static double Factorio(int fact)
        {
            int x = fact;

            for (int i = 1; i < fact; i++)
            {
                x = x * i;
            }

            return x;


        }
    }
}
