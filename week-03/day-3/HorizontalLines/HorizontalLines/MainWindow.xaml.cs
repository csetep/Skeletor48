﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace HorizontalLines
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            double xParameter = 50.0;
            double yParameter = 34.0;

            DrawThreeLinesToTheCenter(foxDraw, xParameter, yParameter);

        }

        public static void DrawThreeLinesToTheCenter(FoxDraw foxDraw, double xParameter, double yParameter)
        {
            double x1 = xParameter;
            double y1 = yParameter;
            double x2 = x1+50;
            double y2 = y1;
            
            for (int i = 1; i < 4; i++)
            {
                foxDraw.StrokeColor(Colors.Yellow);
                foxDraw.DrawLine(x1, (y1), x2, y2);
                           
                y1 += i * 60;
                y2 += i * 60;
            }
        }
    }
}
