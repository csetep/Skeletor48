using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBunnies = int.Parse(Console.ReadLine());
            int numberOfEars = 0;
            numberOfEars = BunnyEarCounter(numberOfBunnies, numberOfEars);
            Console.WriteLine(numberOfEars);
            Console.ReadKey();
        }
        public static int BunnyEarCounter(int numberOfBunnies, int numberOfEars)
        {
            if (numberOfBunnies == 0)
            {
                return numberOfEars;
            }
            else if (numberOfBunnies % 2 == 0)
            {
                return BunnyEarCounter(numberOfBunnies - 1, numberOfEars + 3);
            }
            else //if (numberOfBunnies % 2 != 0)
            {
                return BunnyEarCounter(numberOfBunnies - 1, numberOfEars + 2);
            }
        }
    }
}
