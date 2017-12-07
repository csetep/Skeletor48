using System;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Summerize(n));
            Console.ReadKey();
        }
        public static int Summerize(int n)
        {
            if (n == 0)
                return 0;

            return n + Summerize(--n);
        }
    }
}