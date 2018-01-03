using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            NameOfInstrument = "Violin";
            NumberOfStrings = 4;
        }

        public Violin(int strings)
        {
            NameOfInstrument = "Violin";
            NumberOfStrings = strings;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
