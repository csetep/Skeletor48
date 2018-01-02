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
        Printer printer = new Printer();

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

        public double ThirstyPlantCounter()
        {
            double numberOfThirstyPlants = 0;

            foreach (var plant in plantList)
            {
                if (plant.CurrentWaterAmount <= plant.ThirstIndex)
                {
                    numberOfThirstyPlants++;
                }
            }

            return numberOfThirstyPlants;
        }

        public string WateringGarden(double amountOfWater)
        {
            foreach (var plant in plantList)
            {
                if (plant.CurrentWaterAmount <= plant.ThirstIndex)
                {
                    plant.CurrentWaterAmount += (amountOfWater / ThirstyPlantCounter()) * plant.AbsorbCapacity;
                }
            }

            Console.WriteLine("Watering with {0}", amountOfWater);
            return GetGardenStatus();
        }
    }
}
