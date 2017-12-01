using System;
using System.Linq;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };

            // #1

            af.ToList().ForEach(Console.WriteLine);

            // #2

            Console.WriteLine("[{0}]", string.Join(", ", af));

            // #3

            foreach (int numbers in af)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}