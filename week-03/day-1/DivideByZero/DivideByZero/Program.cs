using System;
using System.IO;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number");

            try
            {
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("False");
            }
            catch (Exception )
            {
                Console.WriteLine("Something went wrong...");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
