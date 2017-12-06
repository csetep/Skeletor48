using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace MiddleLines
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRedHorizontalLine(foxDraw);
            DrawGreenVerticalLine(foxDraw);


        }

        public static void DrawRedHorizontalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 200, 400, 200);            
        }

        public static void DrawGreenVerticalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(200, 0, 200, 400);
        }
    }
}
