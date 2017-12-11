using System.Windows;
using System.Windows.Media;
using GreenFox;

namespace RainbowBoxFunction
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            double size = 400;
            double canvasSize = 400;
            double numberOfColours = 7;
            double downsize = (size / numberOfColours);

            byte[] rArray = { 148, 75, 0, 0, 255, 255, 255 };
            byte[] gArray = { 0, 0, 0, 255, 255, 127, 0 };
            byte[] bArray = { 211, 130, 255, 0, 0, 0, 0 };

            for (int i = 0; i < numberOfColours; i++)
            {
                byte r = rArray[i];
                byte g = gArray[i];
                byte b = bArray[i];
                Color color = Color.FromRgb(r, g, b);

                DrawBoxesCenter(foxDraw, canvasSize, size, color);
                size -= downsize;
            }
        }

        public static void DrawBoxesCenter(FoxDraw foxDraw, double canvasSize, double size, Color color)
        {
            foxDraw.FillColor(color);
            foxDraw.DrawRectangle(((canvasSize - size) / 2), ((canvasSize - size) / 2), size, size);
        }
    }
}
