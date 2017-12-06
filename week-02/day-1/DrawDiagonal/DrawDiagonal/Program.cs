using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number = int.Parse(Console.ReadLine());

            string o = "o";

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (i == 0 || i == number - 1)
                    {
                        Console.Write(o);
                    }
                    else if (j == 0 || j == number - 1 ||i==j)
                    {
                        Console.Write(o);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
