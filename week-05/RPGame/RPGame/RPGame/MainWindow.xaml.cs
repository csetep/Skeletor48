﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace RPGame
{

    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;
        private double x = 0;
        private double y = 0;
        Map map = new Map();

        public MainWindow()
        {
            InitializeComponent();

            FoxDraw = new FoxDraw(canvas);

            map.MapBuilder(FoxDraw);

            FoxDraw.AddHeroImage("Assets/hero-down.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-up.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-left.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-right.png", x, y);
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down && y < 500)
            {
                y += 50;
                for (int i = 0; i < map.wallYCoordinates.Count; i++)
                {
                    if (y == map.wallYCoordinates[i] && x == map.wallXCoordinates[i])
                    {
                        y -= 50;
                    }
                }
                FoxDraw.SetPosition(FoxDraw.HeroImages[0], x, y);
            }

            if (e.Key == Key.Up && y > 0)
            {
                y -= 50;
                for (int i = 0; i < map.wallYCoordinates.Count; i++)
                {
                    if (y == map.wallYCoordinates[i] && x == map.wallXCoordinates[i])
                    {
                        y += 50;
                    }
                }
                FoxDraw.SetPosition(FoxDraw.HeroImages[0], x, y);
            }

            if (e.Key == Key.Left && x > 0)
            {
                x -= 50;
                for (int i = 0; i < map.wallYCoordinates.Count; i++)
                {
                    if (x == map.wallXCoordinates[i] && y == map.wallYCoordinates[i])
                    {
                        x += 50;
                    }
                }
                FoxDraw.SetPosition(FoxDraw.HeroImages[0], x, y);
            }

            if (e.Key == Key.Right && x < 450)
            {
                x += 50;
                for (int i = 0; i < map.wallYCoordinates.Count; i++)
                {
                    if (x == map.wallXCoordinates[i] && y == map.wallYCoordinates[i])
                    {
                        x -= 50;
                    }
                }
                FoxDraw.SetPosition(FoxDraw.HeroImages[0], x, y);
            }
        }
    }
}
