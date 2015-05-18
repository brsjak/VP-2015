using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FlyingBalls
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS = 30;
        public int State { get; set; }//sostojba za boja i brisenje pri animacija
        public Point Center { get; set; }

        public Ball(Point center)
        {
            Center = center;
            Random rand = new Random();
            State = rand.Next(3);
        }
        public void Draw(Graphics g)
        {
            Brush b = null;
            if (State == 0)
            {
                b = new SolidBrush(Color.Green);
            }
            else if (State == 1)
            {
                b = new SolidBrush(Color.Blue);
            }
            else
            {
                b = new SolidBrush(Color.Red);
            }
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }
        public void Move()
        {
            Center = new Point(Center.X + 10, Center.Y);
        }
        public bool IsHit(Point position)
        {//dali e kliknato topceto so gluvceto, ako bojata e crvena da se izbrise
            if (RADIUS * RADIUS >= ((Center.X - position.X) * (Center.X - position.Y) + (Center.Y - position.Y) * (Center.Y - position.Y)))
            {
                State++;
                if (State == 3) return true;
            }
            return false;
        }
    }
}
