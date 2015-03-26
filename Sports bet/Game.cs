using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{    /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public class Game
    {
        public Team Home { get; set; }
        public Team Guest { get; set; }
        public float[] Coefitients { get; set; }
        public string Code { get; set; }

        public Game() {
            Coefitients = new float[3];
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}-{2} {3:0.00} {4:0.00} {5:0.00}",
                Code, Home.Name, Guest.Name, Coefitients[0], Coefitients[1], Coefitients[2]);
        }

    }
}
