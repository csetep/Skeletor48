using System;
using System.Linq;

namespace LinqExerciseFive.cs
{
    class LinqFive
    {
        static void Main(string[] args)
        {
            string characters = "Be yourself; everyone else is already taken";


            var occurrenceOfCharacters = from cha in characters
                                         orderby cha ascending
                                         group cha by cha into c
                                         select new { c.Key, Count = c.Count() };

            var occurenceOfCharactersTwo = characters.OrderBy(c => c).GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            occurrenceOfCharacters.ToList().ForEach(i => Console.WriteLine(i));
            occurenceOfCharactersTwo.ToList().ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
