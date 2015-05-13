using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rectangles
{
    [Serializable]
    public class Rectangle
    {/*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
        public Point Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Rectangle(Point position, int width, int height, Color color)
        {
            Position = position;
            Width = width;
            Height = width;
            Color = color;
            IsSelected = false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            if (IsSelected)
            {
                Pen p = new Pen(Brushes.Red, 2);
                g.DrawRectangle(p, Position.X, Position.Y, Width, Height);
                p.Dispose();
            }
            g.FillRectangle(b, Position.X, Position.Y, Width, Height);
            b.Dispose();
        }
        public void Select(Point p)
        {
            if (p.X >= Position.X && p.X <= Position.X + Width && p.Y >= Position.Y && p.Y <= Position.Y + Height)
            {
                IsSelected = !IsSelected;
            }
        }
    }
}
