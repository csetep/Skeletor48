using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            Console.WriteLine(ReReverse(reversed));
            Console.ReadLine();
        }

        public static string ReReverse(string text)
        {
            string rereversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                rereversed += text[i];
            }

            return rereversed;
        }
    }
}
