using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int triangle = Convert.ToInt32(Console.ReadLine());
            string star = "*";

            for (int i = 0; i < triangle; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }

            Console.ReadKey();

        }
    }
}
