using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class Product
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public string Name { get; set; }
        public string Code { get; set; }
        public float Price { get; set; }

        public Product(string name, string code, float price)
        {
            Name = name;
            Code = code;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} {2:0.00}", Code, Name, Price);
        }
    }
}
