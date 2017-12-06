using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace CenterBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            double size = 180.0;

            DrawThreeSquares(foxDraw, size);
        }

        public static void DrawThreeSquares(FoxDraw foxDraw, double size)
        {
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                double centerX = (400 - size) / 2;
                double centerY = (400 - size) / 2;

                foxDraw.FillColor(Color.FromArgb(
                    (byte)60,
                    (byte)random.Next(255),
                    (byte)random.Next(255),
                    (byte)random.Next(255)));
                foxDraw.DrawRectangle(centerX, centerY, size, size);

                size = size / 2;                
            }
        }
    }
}
