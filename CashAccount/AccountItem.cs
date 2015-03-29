using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAccount
{
    public class AccountItem
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public AccountItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return string.Format("{0} {1:0.00} X {2} = {3:0.00}", Product.Name, Product.Price, Quantity,
                Quantity * Product.Price);
        }
    }
}


