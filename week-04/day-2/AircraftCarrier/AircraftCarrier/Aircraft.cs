using System;
using System.Collections.Generic;

namespace AircraftCarrier
{
    class Aircraft
    {
        public int CurrentAmmo { get; set; } = 0;
        public int BaseDamage { get; set; }
        public int MaxAmmo { get; set; }
        public int AllDamage { get; set; }
        public string Type { get; set; }

        public Aircraft(int maxAmmo, int baseDamage)
        {
            MaxAmmo = maxAmmo;
            BaseDamage = baseDamage;
        }

        public int Fight()
        {
            int damage = CurrentAmmo * BaseDamage;
            CurrentAmmo = 0;
            return damage;
        }

        public int Refill(int capacity)
        {
            if (capacity < MaxAmmo)
            {
                CurrentAmmo = capacity;
                capacity = 0;
            }
            else
            {
                CurrentAmmo = MaxAmmo;
                capacity = capacity - MaxAmmo;
            }
            AllDamage = BaseDamage * CurrentAmmo;
            return capacity;
        }

        public string GetAircraftStatus()
        {
            return String.Format("Type: {0} Ammo: {1}, BaseDamage: {2}, AllDamage:{3} \n \r"
                 , Type, CurrentAmmo, BaseDamage, AllDamage);
        }
    }
}
