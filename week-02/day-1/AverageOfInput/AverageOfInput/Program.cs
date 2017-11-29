using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tGive me five numbers in a row!\n\tPlease press enter after each number! ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;

            Console.WriteLine("\n\n\n\t The sum of the five numbers is {0} and the average of them is {1}. ", sum, average);
            Console.ReadKey();
        }
    }
}
