using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MovingBalls
{    /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    [Serializable]
    public class Ball
    {
        public Point Center { get; set; }
        public static readonly int RADIUS = 25;
        public static readonly int SPEED = 10;
        public Color Color { get; set; }
        public bool IsMoving { get; set; }
        public bool MovingDown { get; set; }

        public Ball(Point center, Color color)
        {
            Center = center;
            Color = color;
            MovingDown = false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            b.Dispose();
        }
        public void Move(int height)
        {
            if (MovingDown)
            {//odi nagore za 10;
                Center = new Point(Center.X, Center.Y + SPEED);
            }
            else
            {//odi nadolu za 10
                Center = new Point(Center.X, Center.Y - SPEED);
            }
            if (Center.Y + RADIUS >= height - 50)
            {
                MovingDown = false;
            }
            else if (Center.Y - RADIUS <= 50)
            {
                MovingDown = true;
            }
        }
    }
}
