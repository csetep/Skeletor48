﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace PurpleSteps3d
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            int multiplier = 1;
            int squarePosition = multiplier * 10;
            int squareSize = squarePosition;

            for (int i = 0; i <= 6; i++)

            {
                DrawPurpleSquare(foxDraw, squarePosition, (squareSize * i));
                squarePosition = squarePosition + (i * squareSize);
            }
        }

        public static void DrawPurpleSquare(FoxDraw foxDraw, int squarePosition, int squareSize)
        {
            int x1 = squarePosition;
            int y1 = squarePosition;
            int width = squareSize;
            int height = squareSize;

            foxDraw.FillColor(Color.FromRgb(250, 7, 226));
            foxDraw.DrawRectangle(x1, y1, width, height);
        }
    }
}
