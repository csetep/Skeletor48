using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier aurora = new Carrier();
            Carrier enterprise = new Carrier();

            aurora.GetStatus();
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F35");
            aurora.GetStatus();
            aurora.Fill();
            aurora.GetStatus();
            aurora.CarrierFight(enterprise);
            enterprise.GetStatus();
            aurora.GetStatus();
            aurora.Fill();
            aurora.CarrierFight(enterprise);
            aurora.GetStatus();
            enterprise.GetStatus();
            
            Console.ReadKey();
        }
    }
}
