using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Player
    {  /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
        */
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            Name = name;
            Points = points;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Points);
        }
    }
}
