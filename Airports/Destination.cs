using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Destination
    {  /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public Destination(string name, int distance, int price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} km - {2} EUR", Name, Distance, Price);
        }
    }
}
