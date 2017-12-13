using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Aircraft
    {
        public int Ammo { get; set; }
        public int BaseDamage { get; set; }
        public string Type { get; set; }
        public int MaxAmmo { get; set; }
        public int AllDamage { get; set; }

        public Aircraft()
        {

        }

        public string getType()
        {
            return Type;
        }
    }
}
