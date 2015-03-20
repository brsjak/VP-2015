using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder
{
    class Dessert
    {
         /*
         ** author: Damjan Miloshevski
         ** contact: d.miloshevski@gmail.com;
         ** skype: damjan.milosevski
         ** phone: +38978566409;
         ** web: https://www.facebook.com/damjan.miloshevski
                 http://miloshevski.us.to/
       */
        public string Name { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
