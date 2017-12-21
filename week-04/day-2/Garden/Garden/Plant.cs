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
        public double CurrentWaterAmount = 0;
        public double AbsorbCapacity { get; set; }
        public string PlantType { get; set; }
        public int ThirstIndex { get; set; }
        public bool Thirsty { get; set; }


        public Plant()
        {
            
        }

        public bool ThirstChecker()
        {
            if (CurrentWaterAmount <= ThirstIndex)
            {
                return Thirsty;
            }
            return Thirsty;
        }

        public string FlowerStatus()
        {
            if (CurrentWaterAmount <= ThirstIndex)
            {
                return String.Format("The {0} {1} needs water \r\n", Color, PlantType);

            }
            else if(CurrentWaterAmount > ThirstIndex)
            {
                return String.Format("The {0} {1} doesn't need water \r\n",Color,PlantType);
            }
            return "0";
        }
            


    }
}


