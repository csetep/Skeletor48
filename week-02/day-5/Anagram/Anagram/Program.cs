using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two words and than press enter!");
            string inputone = (Console.ReadLine());
            char[] toAnagramFunctionOne = inputone.ToUpper().ToCharArray();

            string inputtwo = (Console.ReadLine());
            char[] toAnagramFunctionTwo = inputtwo.ToUpper().ToCharArray();

            IsAnagram(toAnagramFunctionOne, toAnagramFunctionTwo);


            Console.ReadKey();
        }

        static void IsAnagram(char[] charListOne, char[] charListTwo)
        {

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
        }
    }
}
