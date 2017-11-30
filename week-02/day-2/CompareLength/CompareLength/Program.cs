using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = { "1", "2", "3"};
            string[] p2 = { "4", "5",};

            bool more = true;

            more = (p1.Length < p2.Length);

            if (more)
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else if (more != true)
            {
                Console.WriteLine("p2 has less elements less than p1");
            }
            else
            {
                Console.WriteLine("p2 has equal numbers of elements to p1");
            }
            Console.ReadLine();
        }
    }
}
