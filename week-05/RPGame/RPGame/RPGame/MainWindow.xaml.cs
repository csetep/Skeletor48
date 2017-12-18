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

namespace RPGame
{

    public partial class MainWindow : Window
    {
        private FoxDraw FoxDraw;

        private double x = 0;
        private double y = 0;

        public MainWindow()
        {
            InitializeComponent();
            FoxDraw = new FoxDraw(canvas);
            var map = new Map();


            map.MapBuilder(FoxDraw);

            FoxDraw.AddHeroImage("Assets/hero-down.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-up.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-left.png", x, y);
            FoxDraw.AddHeroImage("Assets/hero-right.png", x, y);


        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Down)
            {
                if (y < 450)
                {
                    y += 50;
                    FoxDraw.SetPosition(FoxDraw.HeroImages[0], x, y);
                }
            }

            if (e.Key == Key.Up)
            {
                if (y > 0)
                {
                    y -= 50;
                    FoxDraw.SetPosition(FoxDraw.HeroImages[1], x, y);
                }
            }

            if (e.Key == Key.Left)
            {
                if (x > 0 )
                {
                    x -= 50;
                    FoxDraw.SetPosition(FoxDraw.HeroImages[2], x, y);
                }
            }

            if (e.Key == Key.Right)
            {
                if (x <450 )
                {
                    x += 50;
                    FoxDraw.SetPosition(FoxDraw.HeroImages[3], x, y);
                }
            }
        }
    }
}