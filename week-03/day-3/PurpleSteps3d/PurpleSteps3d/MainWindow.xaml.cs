using System;
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
            double squarePosition = multiplier * 10;
            double squareSize = squarePosition;
            

            for (double i = 0; i < 16; i++)
            {
                double j = 0;
               

                DrawPurpleSquare(foxDraw, (squarePosition*(i+(j*))), (squareSize *(i+1)));
                j++;
                j += j;
            }
        }

        public static void DrawPurpleSquare(FoxDraw foxDraw, double squarePosition, double squareSize)
        {
            double x1 = squarePosition;
            double y1 = squarePosition;
            double width = squareSize;
            double height = squareSize;

            foxDraw.FillColor(Color.FromRgb(250, 7, 226));
            foxDraw.DrawRectangle(x1, y1, width, height);
        }
    }
}
