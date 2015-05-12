using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class PolygonsScene
    {
        public List<Polygon> Polygons { get; set; }

        [NonSerialized]
        public bool IsChanged;

        public PolygonsScene()
        {
            Polygons = new List<Polygon>();
            IsChanged = false;
        }
        public void AddPolygon(Polygon p)
        {
            Polygons.Add(p);
            IsChanged = true;
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Polygons)
            {
                Polygon p = obj as Polygon;
                p.Draw(g);
            }
        }
        public int GetPolygons()
        {
            return Polygons.Count;
        }
        public void Move(int dx, int dy)
        {
            foreach (object obj in Polygons)
            {
                Polygon p = obj as Polygon;
                p.Move(dx, dy);
            }
        }
    }
}
