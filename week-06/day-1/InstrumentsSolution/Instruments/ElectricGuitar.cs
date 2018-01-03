using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            NameOfInstrument = "Electric Guitar";
            NumberOfStrings = 6;
        }

        public ElectricGuitar(int strings)
        {
            NameOfInstrument = "Electric Guitar";
            NumberOfStrings = strings;
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
