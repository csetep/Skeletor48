using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings;

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}", NameOfInstrument, NumberOfStrings, Sound());
        }
    }
}

