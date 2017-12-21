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

            var Garden = new Garden();
            var yellowFlower = new Flower("yellow", "flower");
            var blueFlower = new Flower("blue", "flower");
            var purpleTree = new Tree("purple", "tree");
            var orangeTree = new Tree("orange", "tree");

            Garden.PlantList.Add(yellowFlower);
            Garden.PlantList.Add(yellowFlower);
            Garden.PlantList.Add(yellowFlower);
            Garden.PlantList.Add(yellowFlower);






        }
    }
}
