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
            MaxAmmo = 8;
            BaseDamage = 30;
            Ammo = 0;
            AllDamage = BaseDamage * Ammo;       
        }



       
    }
}

