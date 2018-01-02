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
            Printer printer = new Printer();
            var garden = new Garden();

            garden.AddPlant("yellow", "flower");
            garden.AddPlant("blue", "flower");
            garden.AddPlant("purple", "tree");
            garden.AddPlant("orange", "tree");

            printer.PrintMethod(garden.GetGardenStatus());
            printer.PrintMethod(garden.WateringGarden(40));
           // printer.PrintMethod(garden.WateringGarden(70));

            Console.ReadKey();
        }
    }
}
