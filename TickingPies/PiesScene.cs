using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class PiesScene
    {
        public List<Pie> Pies { get; set; }

        public PiesScene()
        {
            Pies = new List<Pie>();
        }
        public void AddPie(Pie pie)
        {
            Pies.Add(pie);
        }
        public void Draw(Graphics g)
        {
            foreach (object obj in Pies)
            {
                Pie p = obj as Pie;
                p.Draw(g);
            }
        }
        public void Tick()
        {
            for (int i = Pies.Count - 1; i >= 0; i--)
            {
                Pies[i].Tick++;
                if (Pies[i].Tick == 4)
                {
                    Pies.RemoveAt(i);
                }
            }
        }
        public int GetPies()
        {
            return Pies.Count;
        }
    }
}
