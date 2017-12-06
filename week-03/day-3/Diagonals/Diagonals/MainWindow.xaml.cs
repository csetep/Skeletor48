using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace Diagonals
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawDiagonalLineA(foxDraw);           
            DrawDiagonalLineB(foxDraw);           

        }

        public static void DrawDiagonalLineA(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, 401, 401);
        }

        public static void DrawDiagonalLineB(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 401, 401, 0);
        }              
    }
}
