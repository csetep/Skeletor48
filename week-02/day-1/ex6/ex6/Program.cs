using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int week = 17;
            int workdays = 5;
            int hoursperday = 6;
            int weeklyaveragehours = 52;
            int allhours = week * weeklyaveragehours;
            int allcoding = week * workdays * hoursperday;

            Console.WriteLine(allcoding);
            Console.WriteLine((allcoding/(double)allhours)*100);
            Console.ReadLine();
        }
    }
}