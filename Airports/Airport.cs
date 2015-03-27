using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class Airport
    {   /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
        */
        public string Name { get; set; }
        public string Short { get; set; }
        public string City { get; set; }
        public List<Destination> Destinations { get; set; }

        public Airport(string _short, string name, string city)
        {
            Name = name;
            Short = _short;
            City = city;
            Destinations = new List<Destination>();
        }
        public Airport()
        {
            Destinations = new List<Destination>();
        }
        public void AddDestination(Destination d)
        {
            Destinations.Add(d);
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Short, Name, City);
        }
    }
}
