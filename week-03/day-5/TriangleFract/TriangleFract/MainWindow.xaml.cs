using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace TriangleFract
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            double x1 = 0;
            double y1 = 0;
            double length = 400;
            double counter = 4;

            DrawTriangle(foxDraw, x1, y1, length, counter );
        }

        static void DrawTriangle(FoxDraw foxDraw, double x1, double y1, double length, double counter)
        {
       

            if (counter ==0 )
            
                return;         


            foxDraw.DrawLine(x1, y1, x1+length, y1);
            foxDraw.DrawLine(x1, y1, (length/2),Math.Sqrt(Math.Pow(length,2)-Math.Pow(length/2,2)));
            foxDraw.DrawLine(x1+length, y1, (length/2), Math.Sqrt(Math.Pow(length, 2) - Math.Pow(length / 2, 2)));


            DrawTriangle(foxDraw, x1, y1, length / 2, counter - 1);
            DrawTriangle(foxDraw, x1 + (length / 4), y1 + (Math.Sqrt(Math.Pow(length, 2) - Math.Pow(length / 2, 2)))/2, length / 2, counter - 1);
            DrawTriangle(foxDraw, x1 + length / 2, y1, length / 2, counter - 1);

        }
    }
}
