using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobiles
{   /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public class Automobile
    {
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public float Spending { get; set; }
        public int Price { get; set; }
        public Automobile(Brand brand, string model, float spending, int price)
        {
            Brand = brand;
            Model = model;
            Spending = spending;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} ({2}L) : {3} €", Brand.Name, Model, Spending, Price);
        }
    }
}
