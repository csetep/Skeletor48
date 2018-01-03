using System;
using System.Linq;

namespace LinqExerciseFive.cs
{
    class LinqFive
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var occurrenceOfNumbers = from num in numbers
                                      orderby num ascending
                                      group num by num into n
                                      select new { n.Key, Count = n.Count() };

            occurrenceOfNumbers.ToList().ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
