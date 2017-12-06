using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace PositionSquare
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            double x1 = 150.0;
            double y1 = 150.0;

            DrawThreeSquares(foxDraw, x1, y1);
        }

        public static void DrawThreeSquares(FoxDraw foxDraw, double x1, double y1)
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                foxDraw.FillColor(Color.FromArgb(
                    (byte)70,
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255)));
                foxDraw.DrawRectangle(x1, y1, 50, 50);

                x1 += (double)random.Next(100);
                y1 += (double)random.Next(100);
            }
        }
    }
}
