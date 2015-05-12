using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Elipses
{
    [Serializable]
    public class Scene
    {
        public List<Elipse> Elipses { get; set; }
        public Elipse Elipse { get; set; }

        public Scene()
        {
            Elipses = new List<Elipse>();
        }
        public void AddElipse(Point position, int width, int height)
        {
            Elipse = new Elipse(width, height, position);
            Elipses.Add(Elipse);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Elipses)
            {
                Elipse e = obj as Elipse;
                e.Draw(g);
            }
        }
        public void ChangeColor()
        {
            foreach (object obj in Elipses)
            {
                Elipse e = obj as Elipse;
                e.ChangeColor();
            }
        }
        public int GetElipses()
        {
            return Elipses.Count;
        }
    }
}
