using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSerii
{
   public class TV
    {
        public List<TVProgram> Programi { get; set; }
        public string Ime { get; set; }
        public int Broj { get; set; }

        public TV()
        {   //moze i ne mora da postoi ovoj konstruktor
            Programi = new List<TVProgram>();   
            //se inicijalira bidejki kje frli null exception pri startuvanje ako ne e 
        }
        public TV(string ime,int broj)
        {
            Programi = new List<TVProgram>();
            //se inicijalira bidejki kje frli null exception pri startuvanje ako ne e 
            Ime = ime;
            Broj = broj;
        }
        public override string ToString()
        {
            return string.Format("{0}. {1}", Broj, Ime);
        }

    }
}
