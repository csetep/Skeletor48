using System;

namespace Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double number = int.Parse(Console.ReadLine());
            number = number - 1;

            Console.Write(Fibonacci(number));
            Console.ReadKey();
        }

        public static double Fibonacci(double n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }
    }
}