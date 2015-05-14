using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlowingBallons
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    [Serializable]
    public class Balloon
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public Color Color { get; set; }
        public bool Flag { get; set; }
        public Balloon(int radius, Point center)
        {
            Radius = radius;
            Center = center;
            Random rand = new Random();
            Color = Color.FromArgb((int)rand.Next(0, 255), (int)rand.Next(0, 255), (int)rand.Next(0, 255));
            Flag = false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
        public bool IsTouching(Balloon b)
        {
            double distance = (Center.X - b.Center.X) * (Center.X - b.Center.X) + (Center.Y - b.Center.Y) * (Center.Y - b.Center.Y);
            //rastojanie od X koordinata so X koordinata na vtoriot balon + rastojanie od Y koordinata so Y koordinata na vtoriot balon
            return distance <= ((Radius + b.Radius) * (Radius + b.Radius));//radius^2
        }
    }
}
