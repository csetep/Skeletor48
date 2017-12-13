using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            Type = "F35";
            MaxAmmo = 50;
            BaseDamage = 12;
            Ammo = 0;
            AllDamage = BaseDamage * Ammo;
        }
    }
}
