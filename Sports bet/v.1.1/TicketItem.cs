using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet1_1
{
    public class TicketItem
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Game Game { get; set; }
        public int Tip { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}-{2} {3:0.00}", Game.Code, Game.Home.Name, Game.Away.Name, Game.Coefitients[Tip]);
        }
    }
}
