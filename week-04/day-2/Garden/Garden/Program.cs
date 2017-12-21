using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {

            var garden = new Garden();

            garden.AddPlant("yellow", "flower");
            garden.AddPlant("blue", "flower");
            garden.AddPlant("purple", "tree");
            garden.AddPlant("orange", "tree");

            Console.WriteLine(garden.GetGardenStatus());

            Console.ReadKey();
        }
    }
}
