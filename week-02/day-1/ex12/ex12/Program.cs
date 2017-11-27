using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 32;
            double b = 28;
            double c = 10;

            double surface = 2 * (a * b + a * c + b * c);
            double volume = a * b * c;

            Console.WriteLine("Surface Area: " + surface);
            Console.WriteLine("Volume: " + volume);

            Console.ReadKey();               
                  
        }
    }
}