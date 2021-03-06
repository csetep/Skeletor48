﻿using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn");

            foreach (string planets in planetList)
            {
                Console.WriteLine(planets);
            }

            // Saturn is missing from the planetList
            // Insert it into the correct position

            Console.ReadKey();
        }
    }
}
