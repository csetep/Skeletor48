using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            var f35_01 = new F35();

            Console.WriteLine(f35_01.AllDamage);
            Console.ReadKey();
        }
    }
}
