using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "countlines.txt";

            try
            {
                int numberOfLines = LineCounter(path);
                Console.WriteLine(numberOfLines);
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
            finally
            {
                Console.ReadKey();
            }

        }

        public static int LineCounter(string textFile)
        {
            StreamReader myText = new StreamReader(textFile);

            int lineCount = 0;

            while (myText.ReadLine() != null)
            {
                lineCount++;
            }
            return lineCount;
        }
    }
}
