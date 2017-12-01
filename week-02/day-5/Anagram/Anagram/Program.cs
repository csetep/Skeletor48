using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two words and than press enter!");
            string inputone = (Console.ReadLine());
            char[] charListOne = inputone.ToUpper().ToCharArray();

            string inputtwo = (Console.ReadLine());
            char[] charListTwo = inputtwo.ToUpper().ToCharArray();

            Array.Sort(charListOne);
            Array.Sort(charListTwo);

            bool anagram = true;

            if (charListOne.Length != charListTwo.Length)
            {
                anagram = false;
            }
            else
            {
                for (int i = 0; i < charListOne.Length; i++)
                {

                    anagram = (charListTwo[i] == charListOne[i]);

                    if (anagram)
                    {

                    }

                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(anagram);
            Console.ReadKey();
        }
    }
}
