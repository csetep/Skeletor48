using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Convert.ToInt32(Console.ReadLine());

            string space = " ";
            string star = "*";

            for (int i = 0; i < lines; i++)
            {
                for (int ii = i; ii < lines - 1; ii++)
                {
                    Console.Write(space);
                }

                Console.WriteLine(star);
                star += "**";
            }

            Console.ReadKey();
        }
    }
}
