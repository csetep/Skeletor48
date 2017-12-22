using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{

    public class Plant
    {
        public string Color { get; set; }
        public double CurrentWaterAmount { get; set; } = 0;
        public double AbsorbCapacity { get; set; }
        public string PlantType { get; set; }
        public int ThirstIndex { get; set; }        
        public Garden garden = new Garden();
        
        public Plant(double absorbCapacity, int thirstIndex)
        {
            AbsorbCapacity = absorbCapacity;
            ThirstIndex = thirstIndex;
        }

        public string FlowerStatus()
        {
            if (CurrentWaterAmount <= ThirstIndex)
            {
                return String.Format("The {0} {1} needs water \r\n", Color, PlantType);
            }
            else
            {
                return String.Format("The {0} {1} doesn't need water \r\n", Color, PlantType);
            }
        }       
    }
}
