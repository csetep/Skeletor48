using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        public int HealthPoint { get; set; } = 5000;
        public int AllAmmo = 2300;
        public int CurrentAmmo { get; set; }
        public List<Aircraft> airplaneSquadron = new List<Aircraft>();
        public int TotalDamage = 0;

        public Carrier()
        {
        CurrentAmmo = AllAmmo;
        }

        public void AddAircraft(string type)
        {
            if (type == "F16")
            {
                airplaneSquadron.Add(new F16());
            }
            else if (type == "F35")
            {
                airplaneSquadron.Add(new F35());
            }
        }

        public void Fill()
        {
            foreach (var aircraft in airplaneSquadron)
            {
                if (CurrentAmmo > aircraft.MaxAmmo)
                {
                    CurrentAmmo = aircraft.Refill(CurrentAmmo);
                }
                else if (CurrentAmmo < aircraft.MaxAmmo)
                {
                    if (aircraft.Type == "F35")
                        CurrentAmmo = aircraft.Refill(CurrentAmmo);
                }
            }
        }

        public void CarrierFight(Carrier enemy)
        {

            foreach (var plane in airplaneSquadron)
            {
                TotalDamage += plane.Fight();
            }

            enemy.HealthPoint -= TotalDamage;
        }

        public void GetStatus()
        {
            if (HealthPoint > 0)
            {
                Console.WriteLine("HP: {0}, Aircraft Count: {1}, Ammo Storage: {2}, Total Damage: {3} \nAircrafts:"
                    , HealthPoint, airplaneSquadron.Count, CurrentAmmo, TotalDamage);

                foreach (var plane in airplaneSquadron)
                {
                    Console.WriteLine("Type: {0} Ammo: {1}, BaseDamage: {2}, AllDamage:{3},"
                        , plane.Type, plane.CurrentAmmo, plane.BaseDamage, plane.AllDamage);
                }
            }
            else
            {
                Console.WriteLine("It`s dead Jim! :(");
            }


        }
    }
}
