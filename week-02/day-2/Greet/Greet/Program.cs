using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";

            Greet(al);
            Console.ReadLine();
        }

        static void Greet(string name)
        {
            Console.WriteLine("Greetings dear," + name);
        }
    }
}

