using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GreenFox;

namespace RPGame
{
    class Map
    {
        public void MapBuilder(FoxDraw foxDraw)
        {
            double coordinateX = 0;
            double coordinateY = 0;

            for (int x = 0; x < 10; x++)
            {
                coordinateX =x* 50;

                for (int y = 0; y < 10; y++)
                {
                    coordinateY = y* 50;
                    foxDraw.AddImage("Assets/floor.png", coordinateX, coordinateY);
                }
            }
        }
    }
}
