using System;

namespace PalindromBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word or a sentence, and then press enter!");
            string input = Console.ReadLine();
            char[] toPalindromeBuilder = input.ToCharArray();

            char[] redliumBemordnilaPot = new char[toPalindromeBuilder.Length * 2];

            for (int i = 0; i < toPalindromeBuilder.Length; i++)
            {
                redliumBemordnilaPot[i] += toPalindromeBuilder[i];
                redliumBemordnilaPot[toPalindromeBuilder.Length + (1 * i)] += toPalindromeBuilder[toPalindromeBuilder.Length - (i + 1)];
            }

            foreach (char letters in redliumBemordnilaPot)
            {
                Console.Write(letters);
            }
            Console.ReadLine();
        }
    }
}
