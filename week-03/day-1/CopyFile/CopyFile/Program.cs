using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            bool succes = true;

            try
            {
                StreamReader inputPath = new StreamReader("my-text1.txt");
                StreamWriter outputPath = new StreamWriter("my-text2.txt");

                CopyCat(inputPath, outputPath);

                Console.WriteLine(" I copied the files successfully:{0}", succes);
            }
            catch (Exception)
            {
                succes = false;
                Console.WriteLine(" I copied the files successfully:{0}", succes);
            }
            Console.ReadKey();
        }

        static void CopyCat(StreamReader input, StreamWriter output)
        {
            string line = "";

            while ((line = input.ReadLine()) != null)
            {
                output.WriteLine(line);
            }
            output.Close();
        }
    }
}
