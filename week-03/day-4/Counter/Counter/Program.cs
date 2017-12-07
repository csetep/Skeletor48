using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CountDown(n);
            Console.ReadKey();
        }
        public static void CountDown(int n)
        {
            int counter = n;

            if (counter >= 0)
            {
                Console.WriteLine(n);
                CountDown(counter - 1);
            }
        }
    }
}
