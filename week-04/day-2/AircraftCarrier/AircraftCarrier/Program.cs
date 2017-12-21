using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier aurora = new Carrier();
            Carrier enterprise = new Carrier();

            Console.WriteLine(aurora.GetStatus());
            Console.WriteLine(enterprise.GetStatus());
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F16");
            aurora.AddAircraft("F35");
            aurora.AddAircraft("F35");
            Console.WriteLine(aurora.GetStatus());

            aurora.TotallyUnnecessaryFillMethodJustToCatchTheTotallyUnnecessaryExceptionMadeByMe();
            Console.WriteLine(aurora.GetStatus());

            //aurora.Attack(enterprise);
            //Console.WriteLine(enterprise.GetStatus());

            //aurora.TotallyUnnecessaryFillMethodJustToCatchTheTotallyUnnecessaryExceptionMadeByMe();        
            //aurora.Attack(enterprise);
            //Console.WriteLine(enterprise.GetStatus());

            //aurora.TotallyUnnecessaryFillMethodJustToCatchTheTotallyUnnecessaryExceptionMadeByMe();
            //aurora.Attack(enterprise);
            //Console.WriteLine(enterprise.GetStatus());

            Console.ReadKey();
        }
    }
}
