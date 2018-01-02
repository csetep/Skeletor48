using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    public class Tree : Plant
    {
        public Tree(string color) : base(0.4, 10)
        {
            Color = color;
            PlantType = "Tree";
            CurrentWaterAmount = 0;
        }
    }
}
