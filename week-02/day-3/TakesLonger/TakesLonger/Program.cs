using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string fix = "always takes longer than ";
            int positionOfFix = quote.IndexOf("you expect");

            var theHof = new StringBuilder();
            theHof.Append(quote);
            theHof.Insert(positionOfFix, fix);

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(theHof);
            Console.ReadKey();
        }
    }
}


