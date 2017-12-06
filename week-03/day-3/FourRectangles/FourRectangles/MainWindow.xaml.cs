using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace FourRectangles
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            DrawRectangles(foxDraw);
        }

        public static void DrawRectangles(FoxDraw foxDraw)
        {
            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
            foxDraw.DrawRectangle(
                (double)random.Next(200), 
                (double)random.Next(200), 
                (double)random.Next(200), 
                (double)random.Next(200));
            foxDraw.FillColor(Color.FromRgb(
                (byte)random.Next(255),
                (byte)random.Next(255),
                (byte)random.Next(255)));
            }
        }       
    }
}
