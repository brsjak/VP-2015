using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvSerii
{
    public class TVProgram
    {
        public string Ime { get; set; }
        public int Casovi { get; set; }
        public int Minuti { get; set; }

        public TVProgram()
        {
            //moze i ne mora da postoi
        }
        public TVProgram(string ime, int casovi,int minuti)
        {
            Ime = ime;
            Casovi = casovi;
            Minuti = minuti;  
        }
        public override string ToString()
        {
            return string.Format("{0} {1}:{2:0#}",Ime,Casovi,Minuti);
            //:0# e string format da dodade vodecka 0 ako brojot e < 10 
        }
    }
}
