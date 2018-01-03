using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            NameOfInstrument = "Bass Guitar";
            NumberOfStrings = 4;
        }

        public BassGuitar(int strings)
        {
            NameOfInstrument = "Bass Guitar";
            NumberOfStrings = strings;
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
