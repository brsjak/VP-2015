using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TickingPies
{
    /*
   * @author: Damjan Miloshevski
   * contact: +38978566408
   * web: http://miloshevski.us.to
   * skype: damjan.milosevski
   * e-mail: d.miloshevski@gmail.com
   */
    [Serializable]
    public class Pie
    {
        public Point Position { get; set; }
        public Color Color { get; set; }

        private static int RADIUS = 30;
        public int Tick { get; set; }

        public Pie(Point position, Color color)
        {
            Position = position;
            Color = color;
            Tick = 0;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillPie(b, Position.X - RADIUS, Position.Y - RADIUS, RADIUS * 2, RADIUS * 2, 0,
                Convert.ToInt32((4 - Tick) * 90));
            b.Dispose();
        }
    }
}
