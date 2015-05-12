using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Elipses
{
    [Serializable]
    public class Elipse
    {
        public Point Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        [NonSerialized]
        public Brush CurrentColor;

        public Elipse(int width, int height, Point position)
        {
            Random rgb = new Random();
            Position = position;
            Width = width;
            Height = height;
            R = rgb.Next(0, 256);
            G = rgb.Next(0, 256);
            B = rgb.Next(0, 256);
            CurrentColor = new SolidBrush(Color.FromArgb(R, G, B));
        }
        public void Draw(Graphics g)
        {
            g.FillEllipse(CurrentColor, Position.X, Position.Y, Width, Height);
        }
        public void ChangeColor()
        {
            Random rgb = new Random();
            R += 20;
            G += 5;
            B += 25;
            R = R % 256;
            G = G % 256;
            B = B % 256;
        }
    }
}
