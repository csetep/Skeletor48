using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.ReadAllText(@"my-file.txt");
                Console.WriteLine(File.ReadAllText(@"my-file.txt"));
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
