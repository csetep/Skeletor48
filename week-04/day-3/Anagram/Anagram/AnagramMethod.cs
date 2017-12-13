using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramMethod
    {
        public static bool IsAnagram(string inputOneV, string inputTwoV)
        {
            char[] charsToTrim = {' '};
            string inputOneZ = inputOneV;
            string inputOne = inputOneZ.Trim(charsToTrim);
            string inputTwoZ = inputTwoV;
            string inputTwo = inputTwoZ.Trim(charsToTrim);

            char[] charListOne = inputOne.ToUpper().ToCharArray();            
            char[] charListTwo = inputTwo.ToUpper().ToCharArray();

            Array.Sort(charListOne);
            Array.Sort(charListTwo);
            bool anagram = true;

            if (charListOne.Length != charListTwo.Length)
            {
                anagram = false;
                return anagram;
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
                return anagram;
            }
        }
    }
}