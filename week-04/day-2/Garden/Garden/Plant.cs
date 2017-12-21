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

        public bool ThirstChecker()
        {
            if (CurrentWaterAmount <= ThirstIndex)
            {
                return true;
            }
            return false;
        }
    }
}


