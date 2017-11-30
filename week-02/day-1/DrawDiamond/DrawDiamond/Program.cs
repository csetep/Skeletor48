using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Convert.ToInt32(Console.ReadLine());

            string star = "*";

            for (int i = 0; i < lines / 2; i++)
            {

                for (int ii = i; ii < lines - 1; ii++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(star);
                star += "**";
            }

            for (int i = lines / 2; i > 0; i--)
            {

                for (int ii = i; ii < lines; ii++)
                {
                    Console.Write(" ");
                }

                for (int j = i * 2 - 1; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

