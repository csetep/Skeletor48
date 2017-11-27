using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 13;
            int number2 = 22;

            Console.WriteLine(number1 + number2);
            Console.WriteLine(number2 - number1);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number2 / (double)number1);
            Console.WriteLine(number2 / number1);
            Console.WriteLine(number2 % number1);
            Console.ReadLine();
        }
    }
}
