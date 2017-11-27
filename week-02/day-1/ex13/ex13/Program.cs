using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int twentyfourhour = 24 * 60 * 60;
            int currenttime = 14 * 60 * 60 + 34 * 60 + 42;
            int targetTime = twentyfourhour - currenttime;

            Console.WriteLine(targetTime);
            Console.WriteLine(twentyfourhour);
            Console.WriteLine(currenttime);

            for(int i =0; i <= targetTime; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
       

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}