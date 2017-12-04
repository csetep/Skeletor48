using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader inputPath = new StreamReader("my-text1.txt");
            StreamWriter outputPath = new StreamWriter("my-text2.txt");

            CopyCat(inputPath, outputPath);

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




// Write a function that reads all lines of a file and writes 
// the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful