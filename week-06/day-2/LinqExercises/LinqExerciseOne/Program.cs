using System;
using System.Linq;

namespace LinqExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var filteredNumbers = numbers.Where(n => n % 2 == 0).ToList();
            filteredNumbers.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
