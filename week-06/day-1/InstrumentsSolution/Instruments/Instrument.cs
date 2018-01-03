using System;
using System.Collections.Generic;
using System.Text;

namespace Instruments
{
    abstract class Instrument
    {       
        protected string NameOfInstrument { get; set; }
        
        public abstract void Play();
    }
}

