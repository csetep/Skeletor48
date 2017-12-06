using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace CenteredSquare
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            DrawCenteredSquare(foxDraw);
        }

        public static void DrawCenteredSquare(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(195, 195));
            points.Add(new Point(195, 205));
            points.Add(new Point(205, 205));
            points.Add(new Point(205, 195));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }        
    }
}
