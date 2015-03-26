using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBet
{       /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public class Team
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Team() { }
        public Team(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}", Name, Country);
        }
    }
}
