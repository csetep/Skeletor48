using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GreenFox
{
    public class FoxDraw
    {
        private const int TileSize = 50;

        public Canvas Canvas { get; set; }
        public List<Image> TileImages { get; set; }
        public List<Image> HeroImages { get; set; }


        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
            TileImages = new List<Image>();
            HeroImages = new List<Image>();
            //MonsterImages = new List<Image>();

        }

        public void AddTileImage(string source, double x, double y)
        {          
            var tileImage = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            TileImages.Add(tileImage);
            Canvas.Children.Add(tileImage);
            SetPosition(tileImage, x, y);
        }

        public void AddTileImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void AddWallTileImage(string source, double x, double y)
        {
            var wallTileImage = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            TileImages.Add(wallTileImage);
            Canvas.Children.Add(wallTileImage);
            SetPosition(wallTileImage, x, y);
        }

        public void AddWallTileImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void AddHeroImage(string source, double x, double y)
        {
            var heroImage = new Image()
            {
                Width = TileSize,
                Height = TileSize,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            HeroImages.Add(heroImage);
            Canvas.Children.Add(heroImage);
            SetPosition(heroImage, x, y);
        }

        public void AddHeroImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }

        public double GetLeft(UIElement uIElement)
        {
            return Canvas.GetLeft(uIElement);
        }

        public double GetTop(UIElement uIElement)
        {
            return Canvas.GetTop(uIElement);
        }

        public void ClearCanvas()
        {
            Canvas.Children.Clear();
        }
    }
}