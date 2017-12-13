using System;

namespace Anagram
{
    public class AnagramMethod
    {
        public static bool IsAnagram(string inputOne, string inputTwo)
        {
            // string inputOne = inputOneRaw.Replace(" ", "");
            // string inputTwo = inputTwoRaw.Replace(" ", "");
            char[] charListOne = inputOne.Replace(" ", "").ToUpper().ToCharArray();
            char[] charListTwo = inputTwo.Replace(" ", "").ToUpper().ToCharArray();

            Array.Sort(charListOne);
            Array.Sort(charListTwo);

            if (charListOne.Length != charListTwo.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < charListOne.Length; i++)
                {
                    if (charListTwo[i] == charListOne[i])
                    {
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
