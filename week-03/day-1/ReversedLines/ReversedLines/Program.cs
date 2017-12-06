using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;


namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
          

            foreach (var line in File.ReadLines("reversed-lines.txt").Reverse())
            {
    
               
                Console.WriteLine(line);
                Console.ReadKey();
            }
        }
    }
}
