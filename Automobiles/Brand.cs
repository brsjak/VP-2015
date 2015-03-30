using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{
    public class Brand
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public int Code { get; set; }

        public Brand(string name, int code)
        {
            Name = name;
            Code = code;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Code);
        }
    }
}
