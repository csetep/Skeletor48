using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Give me two number and press enter! ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine(" {0} is bigger ! ", number1);

            }
            else if (number1 < number2)
            {
                Console.WriteLine(" {0} is bigger ! ", number2);
            }
            else
            {
                Console.WriteLine(" {0} and {1} are equals! ", number1, number2);
            }
            Console.ReadKey();
        }
    }
}
