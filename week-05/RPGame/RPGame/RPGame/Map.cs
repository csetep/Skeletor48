﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace RPGame
{
    class Map
    {

            public double coordinateX { get; set; }
            public double coordinateY { get; set; }

    
        public void MapBuilder(FoxDraw foxDraw)
        {
            var tileImages = new List<Image>();
            var random = new Random();


            for (int x = 0; x < 10; x++)
            {
                coordinateX = x * 50;

                for (int y = 0; y < 10; y++)
                {
                    coordinateY = y * 50;
                    foxDraw.AddTileImage("Assets/floor.png", coordinateX, coordinateY);
                }
            }

            for (int x = 0; x < 10; x += 2)
            {
                coordinateX = x * 50;

                for (int y = 0; y < 10; y += 2)
                {
                    coordinateY = y * 50;
                    foxDraw.AddTileImage("Assets/wall.png", 50 * random.Next(1, 9), 50 * random.Next(0, 10));
                }
            }
        }
    }
}
