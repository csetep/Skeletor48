using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;


namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputOneV = Console.ReadLine();
            string inputTwoV = Console.ReadLine();

            AnagramMethod.IsAnagram(inputOneV, inputTwoV);
            Console.ReadKey();
        }
    }
}
