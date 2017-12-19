using System;
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

        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double[] TileCoordinates; 

        public void MapBuilder(FoxDraw foxDraw)
        {
            double coordinateX = CoordinateX;
            double coordinateY = CoordinateY;

            var tileImages = new List<Image>();

            int counter = 0;

            string[] wallElements = File.ReadAllLines(@"C:\Users\Misi\greenfox\Skeletor48\week-05\RPGame\RPGame\RPGame\WallTileList.txt").ToArray();

            for (int x = 0; x < 10; x++)
            {
                coordinateX = x * 50;

                for (int y = 0; y < 11; y++)
                {
                    if (wallElements[counter] == "1")
                    {
                        coordinateY = y * 50;
                        foxDraw.AddTileImage("Assets/floor.png", coordinateX, coordinateY);
                    }
                    else
                    {
                        coordinateY = y * 50;
                        foxDraw.AddTileImage("Assets/wall.png", coordinateX, coordinateY);
                        TileCoordinates[counter] = coordinateY;
                    }
                    counter++;
                }
            }
        }
    }
}
