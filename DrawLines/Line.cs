using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public float Thickness { get; set; }

        public Line(Point start, Point end, Color color, float thickness)
        {
            Start = start;
            End = end;
            Color = color;
            Thickness = thickness;
        }
        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color, Thickness);
            g.DrawLine(p, Start, End);
            p.Dispose();
        }

    }
}
