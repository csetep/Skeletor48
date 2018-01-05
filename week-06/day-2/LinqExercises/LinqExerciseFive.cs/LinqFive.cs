using System;
using System.Linq;

namespace LinqExerciseFive.cs
{
    class LinqFive
    {
        static void Main(string[] args)
        {
            //char[] numbers = new char[] { 'k','v', 'C', 'C', 'j', 'l', 'h', 'o'};

            //var occurrenceOfNumbers = from num in numbers
            //                          orderby num ascending
            //                          group num by num into n
            //                          select new { n.Key, Count = n.Count() };

            //occurrenceOfNumbers.ToList().ForEach(i => Console.WriteLine(i));

            var v = new { Amount = 108, Message = "Hello" };
            Console.WriteLine(v);

            Console.ReadKey();
        }
    }
}
