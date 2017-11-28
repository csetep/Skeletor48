
using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of numbers up to {0}", num);
            Console.WriteLine(Sum(num));

            Console.ReadLine();

        }
        public static int Sum(int number)
        {
            return (number * (number + 1)) / 2;
               }
         
    }
}