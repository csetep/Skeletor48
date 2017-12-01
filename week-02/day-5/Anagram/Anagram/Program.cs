using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            //bool anagram = true;
            //anagram = (charListOne.Length != charListTwo.Length);

            if (charListOne.Length != charListTwo.Length)
            {
                Console.WriteLine("False!");
            }
            else
            {
                int count = 0;

                foreach (char letters in charListTwo)
                {
                    if (letters == charListOne[count])
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("False!");
                        break;
                    }
                }

            }


            // AnagramChecker(charListOne, charListTwo);

            Console.ReadKey();
        }






       // static void AnagramChecker(char[] wordone, char[] wordtwo)
        //{
     //       Array.Sort(wordone);
       //     Array.Sort(wordtwo);

            
        //}


    }
}
