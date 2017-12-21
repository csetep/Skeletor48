using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        public int HealthPoint { get; set; } = 5000;
        public int AllAmmo = 330;
        public int CurrentAmmo { get; set; }
        public int TotalDamage { get; set; }
        public List<Aircraft> fighterSquadron = new List<Aircraft>();

        public Carrier()
        {
            CurrentAmmo = AllAmmo;
        }

        public void AddAircraft(string type)
        {
            if (type == "F16")
            {
                fighterSquadron.Add(new F16());
            }
            else if (type == "F35")
            {
                fighterSquadron.Add(new F35());
            }
        }

        public void AmmoChecker()
        {
            if (CurrentAmmo == 0)
            {
                throw new Exception("Out Of Ammo!!!");
            }
        }

        public void Fill()
        {
            try
            {
                AmmoChecker();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            foreach (var fighter in fighterSquadron)
            {
                if (CurrentAmmo < fighter.MaxAmmo * fighterSquadron.Count)
                {
                    if (fighter.Type == "F35")
                    {
                        CurrentAmmo = fighter.Refill(CurrentAmmo);
                    }
                }
                else
                {
                    CurrentAmmo = fighter.Refill(CurrentAmmo);
                }
            }
        }

        public void Attack(Carrier enemy)
        {
            TotalDamage = 0;

            foreach (var fighter in fighterSquadron)
            {
                TotalDamage += fighter.Fight();
            }

            enemy.HealthPoint -= TotalDamage;
        }

        public string GetCarrierStatus()
        {
            if (HealthPoint < 0)
            {
                return "It`s dead Jim! :(";
            }

            return String.Format("HP: {0}, Aircraft Count: {1}, Ammo Storage: {2}, Total Damage: {3} \nAircrafts:\n"
                , HealthPoint, fighterSquadron.Count, CurrentAmmo, TotalDamage);
        }

        public string GetStatus()
        {
            StringBuilder statusStringBuilder = new StringBuilder();

            statusStringBuilder.Append(GetCarrierStatus());

            foreach (var plane in fighterSquadron)
            {
                statusStringBuilder.Append(plane.GetAircraftStatus());
            }

            statusStringBuilder.Append("\n\n");

            return statusStringBuilder.ToString();
        }
    }
}
