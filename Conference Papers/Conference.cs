using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePapers
{
    public class Conference
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public int Year { get; set; }

        public Conference(string name, int year)
        {
            Name = name;
            Year = year;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1}", Year, Name);
        }
    }
}
