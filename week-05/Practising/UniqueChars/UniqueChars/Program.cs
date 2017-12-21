using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    class Program
    {
        static void Main(string[] args)
        {                    
            IEnumerable<string> listOfUniqueLetters = UniqueCharacters1("anagram");

            foreach (var letter in listOfUniqueLetters)
            {
                Console.Write("\"{0}\"", letter);
            }
            Console.ReadKey();

        }              

        public static IEnumerable<string> UniqueCharacters1(string word)
        {
            List<string> list = new List<string>();
            char[] letters = word.ToCharArray();

            foreach (var letter in letters)
            {
                list.Add(letter.ToString());
            }

            IEnumerable<string> listOfUniqueCharacters = list.Distinct();       

            return listOfUniqueCharacters;
        }
    }
}
