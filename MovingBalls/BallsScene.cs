using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBalls
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    [Serializable]
    public class BallsScene
    {
        public List<Ball> Balls { get; set; }

        public BallsScene()
        {
            Balls = new List<Ball>();
        }
        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Balls)
            {
                Ball b = obj as Ball;
                b.Draw(g);
            }
        }
        public void Move(int height)
        {
            foreach (object obj in Balls)
            {
                Ball b = obj as Ball;
                if (b.IsMoving)
                {
                    b.Move(height);
                }
            }
        }
        private double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) - (p1.Y - p2.Y));
        }
        public void StartMoving(Point point)
        {
            foreach (object obj in Balls)
            {
                Ball b = obj as Ball;
                if (Distance(point, b.Center) <= Ball.RADIUS)
                {
                    b.IsMoving = !b.IsMoving;
                }
            }
        }
        public int GetBalls() { return Balls.Count; }
    }
}
