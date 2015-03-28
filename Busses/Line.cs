using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Line
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public int StartHour { get; set; }
        public int StartMinute { get; set; }
        public float Price { get; set; }

        public Line() { }
        public Line(string name, int startHour, int startMinute, float price)
        {
            Name = name;
            StartHour = startHour;
            StartMinute = startMinute;
            Price = price;
        }
        public override string ToString()
        {

            return string.Format("{0:00}:{1:00} - {2} - {3} Ден.", StartHour, StartMinute, Name, Price);
        }
    }
}
