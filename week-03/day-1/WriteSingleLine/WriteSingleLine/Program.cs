using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFile = @"my-file.txt";

            try
            {
                WriteFile(myFile);
                ReadFile(myFile);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadKey();
            }

        }
        static void WriteFile(string myFile)
        {
            File.WriteAllText(myFile, "Banfi Mihaly");
        }

        static void ReadFile(string myFile)
        {
            Console.WriteLine(File.ReadAllText(myFile));
        }
    }
}
