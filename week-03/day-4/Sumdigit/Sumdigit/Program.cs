using System;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sumdigit(n));
            Console.ReadKey();
        }
        public static int Sumdigit(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n<10)
            {
                return n%10;
            }
            else
            {
                return Sumdigit(n / 10) + n % 10;
            }
        }
    }
}