using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace ColoredBox
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawTopHorizontalLine(foxDraw);
            DrawLeftVerticalLine(foxDraw);
            DrawBottomHorizontalLine(foxDraw);
            DrawRightVerticalLine(foxDraw);

        }

        public static void DrawTopHorizontalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 0, 401, 0);
        }

        public static void DrawLeftVerticalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(0, 0, 0, 401);
        }

        public static void DrawBottomHorizontalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.CadetBlue);
            foxDraw.DrawLine(401, 0, 401, 401);
        }

        public static void DrawRightVerticalLine(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 401, 401, 401);
        }
    }
}
