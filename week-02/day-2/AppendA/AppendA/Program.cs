using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";

            appendA(am);
            Console.ReadLine();
        }

        static void appendA(string name)
        {
            Console.WriteLine(name + "a");
        }

    }
}
