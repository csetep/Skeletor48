using System;

namespace UrlFixer
{
    public class UrlFixer
    {
        public static void Main(string[] args)
        {

            string url1 = "https//www.reddit.com/r/nevertellmethebots"; //for version #1
            string url2 = "https//www.reddit.com/r/nevertellmethebots"; //for version #2

            //1. with .Replace

            string correctedUrl1 = url1.Replace("https//www.reddit.com/r/nevertellmethebots", "https://www.reddit.com/r/nevertellmetheodds");

            //2. with .Insert + .Remove 

            string step1 = url2.Insert(5, ":");
            int bots = url1.IndexOf("bots") + 1;
            string step2 = step1.Remove(bots, 4);
            string correctedUrl2 = step2.Insert(39, "odds");

            Console.WriteLine(correctedUrl1);
            Console.WriteLine(correctedUrl2);

            Console.ReadKey();
        }

    }
}