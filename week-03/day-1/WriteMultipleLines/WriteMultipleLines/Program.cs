using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "my-text.txt";

                Console.WriteLine("Type in a word than press enter!");
                string word = Console.ReadLine();

                Console.WriteLine("Type in a number than press enter two times!");
                int number = Convert.ToInt32(Console.ReadLine());

                string[] content = { word };

                Writer(path, content, number);

            }
            catch (Exception)
            {
            }
            finally
            {
                Console.ReadKey();
            }

        }
        static void Writer(string path, string[] content, int number)
        {
            for (int i = 0; i < number; i++)
            {
                File.AppendAllLines(path, content);
            }
        }
    }
}
