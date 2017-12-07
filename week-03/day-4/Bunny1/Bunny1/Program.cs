using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBunnies = int.Parse(Console.ReadLine());
            int numberOfEars = 2;

            Console.WriteLine(BunnyEarCounter(numberOfBunnies, numberOfEars));
            Console.ReadKey();
        }
        public static int BunnyEarCounter(int numberOfBunnies, int numberOfEars)
        {
            if (numberOfBunnies == 1)
            {
                return numberOfEars;
            }
            else
            {
                return BunnyEarCounter(numberOfBunnies - 1, numberOfEars + 2);
            }
        }
    }
}
