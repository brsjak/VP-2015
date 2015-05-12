using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    class LinesDocument
    {
        List<Line> Lines;
        public float Thickness { get; set; }
        public Color CurrentColor { get; set; }
        Point previousLocation;
        Point currentLocation;
        public bool Positioner { get; set; }
        int width;
        int height;

        public LinesDocument(int width, int height)
        {
            Thickness = 2;
            Lines = new List<Line>();
            this.width = width;
            this.height = height;
            Positioner = true;
            CurrentColor = Color.Black;
        }
        public void AddLine(Point location)
        {
            if (!previousLocation.IsEmpty)
            {
                Line line = new Line(previousLocation, location, CurrentColor, Thickness);
                Lines.Add(line);
            }
            previousLocation = location;
        }
        public void Draw(Graphics g)
        {
            foreach (Line line in Lines)
            {
                line.Draw(g);
            }
            if (Positioner)
            {
                Pen p = new Pen(Color.Gray, 1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                //horizontalna linija
                g.DrawLine(p, new Point(0, currentLocation.Y), new Point(width, currentLocation.Y));
                //vertikalna linija
                g.DrawLine(p, new Point(currentLocation.X, 0), new Point(currentLocation.X, height));
                p.Dispose();
            }
        }
        public void Move(int dx, int dy)
        {
            foreach (Line line in Lines)
            {
                line.Start = new Point(line.Start.X + dx, line.Start.Y + dy);
                line.End = new Point(line.End.X + dx, line.End.Y + dy);
                previousLocation = line.End;
            }
        }
        public void UpdateLocation(Point location)
        {
            currentLocation = location;
        }
        public int GetLines()
        {
            return Lines.Count;
        }
        public Point CurrentLocation
        {
            get { return currentLocation; }
        }
    }
}
