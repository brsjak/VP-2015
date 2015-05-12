using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Polygons
{
    [Serializable]
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public bool IsClosed { get; set; }
        public Polygon(Color color)
        {
            Points = new List<Point>();
            Color = color;
            IsClosed = false;
        }
        public void AddPoint(Point point)
        {
            Points.Add(point);
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            Pen p = new Pen(Color, 1);
            if (Points.Count > 2)
            {
                Brush brush = new SolidBrush(Color);
                Pen pen = new Pen(brush, 1);
                if (IsClosed)
                {
                    g.FillPolygon(brush, Points.ToArray());
                }
                else
                {
                    g.DrawLines(pen, Points.ToArray());
                }
                brush.Dispose();
                pen.Dispose();
            }
        }
        public void Move(int dx, int dy)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + dx, Points[i].Y + dy);
            }
        }
    }
}
