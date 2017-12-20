using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier aurora = new Carrier();
            Carrier enterprise = new Carrier();

            aurora.GetStatus();
            enterprise.GetStatus();
            Console.WriteLine("\n");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F35");
            aurora.GetStatus();
            Console.WriteLine("\n");
            aurora.Fill();
            aurora.GetStatus();
            Console.WriteLine("\n");
            enterprise.GetStatus();
            Console.WriteLine("\n");
            aurora.Attack(enterprise);
            enterprise.GetStatus();
            Console.WriteLine("\n");
            aurora.GetStatus();
            Console.WriteLine("\n");
            aurora.Fill();          
            aurora.GetStatus();
            Console.WriteLine("\n");
            aurora.Attack(enterprise);
            aurora.GetStatus();
            Console.WriteLine("\n");
            enterprise.GetStatus();
            Console.WriteLine("\n");
            aurora.Fill();
            aurora.Attack(enterprise);
            aurora.GetStatus();
            Console.WriteLine("\n");
            enterprise.GetStatus();

            Console.ReadKey();
        }
    }
}
