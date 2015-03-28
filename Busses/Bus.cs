using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busses
{
    public class Bus
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public string LicencePlate { get; set; }
        public bool IsLocal { get; set; }
        public List<Line> Lines { get; set; }

        public Bus()
        {
            Lines = new List<Line>();
        }
        public Bus(string name, string licencePlate, bool isLocal)
        {
            Name = name;
            LicencePlate = licencePlate;
            IsLocal = isLocal;
            Lines = new List<Line>();
        }
        public void AddLine(Line l)
        {
            Lines.Add(l);
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, LicencePlate, IsLocal ? "L" : "M");
        }
    }
}
