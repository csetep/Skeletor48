using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = int.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(PowerN(baseNumber, powerNumber));
            Console.ReadKey();
        }
        public static int PowerN(int baseNumber, int powerNumber)
        {
            if (powerNumber == 1)
            {
                return baseNumber;
            }
            else
            {
                return baseNumber * PowerN(baseNumber, powerNumber - 1);
            }
        }
    }
}
