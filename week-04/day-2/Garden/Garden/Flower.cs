using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Flower:Plant
    {
        public Flower(string color) : base(0.75, 5)
        {
            Color = color;
            PlantType = "Flower";            
            CurrentWaterAmount = 0;
        }       
    }
}
