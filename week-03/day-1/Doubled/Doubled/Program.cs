using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader encryptedText = new StreamReader("duplicated-chars.txt");
            StreamWriter decryptedText = new StreamWriter("single-chars.txt");

            Decryptor(encryptedText, decryptedText);

            Console.ReadKey();
        }

        static void Decryptor(StreamReader source, StreamWriter decryptedText)
        {
            string empty = "";
            string text = source.ReadToEnd();
            char[] characters = text.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (i % 2 == 0)
                {
                    empty += characters[i + 1].ToString();
                }
            }
            decryptedText.WriteLine(empty);
            decryptedText.Close();
        }
    }
}
