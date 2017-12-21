using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Garden
    {
        public List<Plant> plantList = new List<Plant>();

        public void AddPlant(string color, string type)
        {
            if (type == "flower")
            {
                plantList.Add(new Flower(color));
            }
            else if (type == "tree")
            {
                plantList.Add(new Tree(color));
            }
        }

        public string GetGardenStatus()
        {
            StringBuilder gardenStringBuilder = new StringBuilder();

            foreach (var plant in plantList)
            {
                gardenStringBuilder.Append(plant.FlowerStatus());
            }

            return gardenStringBuilder.ToString();
        }
    }
}


