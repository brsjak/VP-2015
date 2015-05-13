using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    [Serializable]
    public class RectanglesScene
    {/*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
        public List<Rectangle> Rectangles { get; set; }

        public RectanglesScene()
        {
            Rectangles = new List<Rectangle>();
        }
        public void AddRectangle(Rectangle rect)
        {
            Rectangles.Add(rect);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Rectangles)
            {
                Rectangle rect = obj as Rectangle;
                rect.Draw(g);
            }
        }
        public void Select(Point p)
        {
            foreach (object obj in Rectangles)
            {
                Rectangle rect = obj as Rectangle;
                rect.Select(p);
            }
        }
        public void RemoveSelected()
        {
            for (int i = Rectangles.Count - 1; i >= 0; --i)
            {
                if (Rectangles[i].IsSelected)
                {
                    Rectangles.RemoveAt(i);
                }
            }
        }
        public int GetRectangles()
        {
            return Rectangles.Count;
        }
    }
}
