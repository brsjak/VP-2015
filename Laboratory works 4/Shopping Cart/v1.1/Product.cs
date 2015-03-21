using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart_v1_1
{
    public class Product
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
        public string Category { get; set; }
        public float Price { get; set; }

        public Product() { }

        public Product(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
