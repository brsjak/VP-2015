using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlowingBallons
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    [Serializable]
    public class BallonsScene
    {
        public List<Balloon> Balloons { get; set; }

        public BallonsScene()
        {
            Balloons = new List<Balloon>();
        }
        public void AddBalloon(Balloon b)
        {
            Balloons.Add(b);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Balloons)
            {
                Balloon b = obj as Balloon;
                b.Draw(g);
            }
        }
        public void Pulse()
        {
            foreach (object obj in Balloons)
            {
                Balloon b = obj as Balloon;
                b.Radius += 5;
            }
        }
        public int GetBallons() { return Balloons.Count; }
        public void CheckForExplosions()
        {
            for (int i = 0; i < Balloons.Count; i++)
            {
                for (int j = i + 1; j < Balloons.Count; j++)
                {
                    if (Balloons[i].IsTouching(Balloons[j]))
                    {
                        Balloons[i].Flag = true;
                        Balloons[j].Flag = true;
                    }
                }
            }//izmini gi site baloni i proveri dali se dopiraat, ako se dopiraat postavi na true
            for (int i = Balloons.Count - 1; i >= 0; i--)
            {
                if ((Balloons[i].Flag))
                {
                    Balloons.RemoveAt(i);
                }//ako e true, otstrani
            }
        }
    }
}
