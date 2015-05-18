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
    public class BallsScene
    {
        public List<Ball> Balls { get; set; }
        private int Hits { get; set; }
        private int Misses { get; set; }
        public bool IsPaused { get; set; }
        public BallsScene()
        {
            Balls = new List<Ball>();
            Hits = 0;
            Misses = 0;
            IsPaused = false;
        }
        public void AddBall(Ball b)
        {
            Balls.Add(b);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Balls)
            {
                Ball ball = obj as Ball;
                ball.Draw(g);
            }
        }
        public void IsHit(Point position)
        {
            foreach (object obj in Balls)
            {
                Ball b = obj as Ball;
                b.IsHit(position);
            }
            for (int i = Balls.Count - 1; i >= 0; i--)
            {
                //broi nanazad
                if (Balls[i].State == 3)
                {
                    Balls.RemoveAt(i);
                    Hits++;
                }
            }
        }
        public void Move(int width)
        {//za kolku da se pomestuvaat vo sirina (desno)
            foreach (object obj in Balls)
            {
                Ball b = obj as Ball;
                b.Move();
                if (b.Center.X > width + Ball.RADIUS)
                {
                    //ako e nadvor od granicite na formata
                    b.State = -1;
                }
            }
            for (int i = Balls.Count - 1; i >= 0; i--)
            {//broi nanazad
                if (Balls[i].State == -1)
                {
                    Balls.RemoveAt(i);
                    Misses++;
                }
            }
        }
        public int GetHits() { return Hits; }
        public int GetMisses() { return Misses; }
        public int GetBalls() { return Balls.Count; }
    }
}
