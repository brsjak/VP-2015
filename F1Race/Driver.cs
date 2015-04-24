using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Driver
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsFirst { get; set; }
        public List<Lap> Laps { get; set; }

        public Driver(string name, int age, bool isFirst)
        {
            Name = name;
            Age = age;
            IsFirst = isFirst;
            Laps = new List<Lap>();
        }
        public void AddLap(Lap l)
        {
            Laps.Add(l);
        }
        public override string ToString()
        {
            return string.Format("{0} ({1}) : {2}", Name, Age, IsFirst ? "F" : "S");
        }
    }
}
