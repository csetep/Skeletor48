using System;
using System.Linq;

namespace LinqExerciseFour
{
    class LinqFour
    {
        static void Main(string[] args)
        {
            int[] number = new[] { 3, 9, 2, 8, 6, 5 };

            var filteredNumbers = number.Where(n => (n * n) > 20).ToList();
            filteredNumbers.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
