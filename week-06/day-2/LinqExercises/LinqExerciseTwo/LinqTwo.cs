using System;
using System.Linq;

namespace LinqExerciseTwo
{
    class LinqTwo
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var averageOfOddNumbers = numbers.Where(n => n % 2 == 1 || n % 2 == -1)
                .ToList()
                .Average();

            Console.WriteLine(averageOfOddNumbers);

            Console.ReadKey();
        }
    }
}
