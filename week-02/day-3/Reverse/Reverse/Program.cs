using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            Console.WriteLine(Revolver(reversed));
            Console.ReadLine();
        }

        public static string Revolver(string reversedtext)
        {
            string revolverText = "";

            for (int i = reversedtext.Length - 1; i >= 0; i--)
            {
                revolverText += reversedtext[i];
            }

            return revolverText;
        }
    }
}
