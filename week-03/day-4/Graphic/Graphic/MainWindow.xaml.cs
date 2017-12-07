using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace Graphic
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);

            double squareX = 0;
            double squareY = 0;
            double squareSize = 603;
            double counter = 0;
            DrawSquare(foxDraw, squareX, squareY, squareSize, counter);
        }

        public static void DrawSquare(FoxDraw foxDraw, double squareX, double squareY, double squareSize, double counter)
        {
            if (counter < 9)
            {
                foxDraw.FillColor(Color.FromArgb(60, 254, 124, 34));
                foxDraw.DrawRectangle(squareX, squareY, squareSize, squareSize);
                counter++;

                DrawSquare(foxDraw, squareX, (squareY + squareSize / 3), squareSize / 3, counter);
            }
        }
    }
}
