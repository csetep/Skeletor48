using System;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAdder(n));
            Console.ReadKey();
        }
        public static int NumberAdder(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
    }
}