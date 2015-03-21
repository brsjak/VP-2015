using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart_v1_1
{
    /*
       ** author: Damjan Miloshevski
       ** contact: d.miloshevski@gmail.com;
       ** skype: damjan.milosevski
       ** phone: +38978566409;
       ** web: https://www.facebook.com/damjan.miloshevski
               http://miloshevski.us.to/
      */
    public class ProductItem
    {
        public Product Product { get; set; }
        public float Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("{0:0.0} {1:0.0} x {2:0.0} = {3:0.00}", Product.ToString(), Quantity,
                Product.Price, Quantity * Product.Price);
        }
    }
}
