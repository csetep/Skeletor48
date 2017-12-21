using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Flower:Plant
    {
        public Flower(string color)
        {
            Color = color;
            PlantType = "Flower";
            AbsorbCapacity = 0.4;
            ThirstIndex = 5;
        }       
    }
}
