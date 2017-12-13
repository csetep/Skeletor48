using System;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();

            AnagramMethod.IsAnagram(inputOne, inputTwo);
            Console.ReadKey();
        }
    }
}
