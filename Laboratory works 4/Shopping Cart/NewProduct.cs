using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class NewProduct : Form
    {
        /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Product Product { get; set; }
        public NewProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbNewProductName.Text;
            string category = tbNewProductCategory.Text;
            float price = 0;
            float f = 0;
            if (float.TryParse(tbNewProductPrice.Text, out f))
            {
                price = f;
            }
            Product = new Product(name, category, price);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbNewProductName_Validating(object sender, CancelEventArgs e)
        {
            if (tbNewProductName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorName.SetError(tbNewProductName, "Внесете име!");
            }
            else
            {
                errorName.SetError(tbNewProductName, null);
            }
        }

        private void tbNewProductCategory_Validating(object sender, CancelEventArgs e)
        {
            if (tbNewProductCategory.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorCategory.SetError(tbNewProductCategory, "Внесете категорија!");
            }
            else
            {
                errorCategory.SetError(tbNewProductName, null);
            }
        }

        private void tbNewProductPrice_Validating(object sender, CancelEventArgs e)
        {
            if (lblNewProductPrice.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorPrice.SetError(tbNewProductPrice, "Внесете цена!");
            }
            else
            {
                errorPrice.SetError(tbNewProductName, null);
            }
        }
    }
}
