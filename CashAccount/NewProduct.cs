using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class NewProduct : Form
    {/*
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

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorName.SetError(tbName, null);
                btnEnter.Enabled = true;
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името на производот е задолжително!");
            }
        }

        private void numPrice_Validating(object sender, CancelEventArgs e)
        {
            if (numPrice.Value > 0)
            {
                errorPrice.SetError(numPrice, null);
            }
            else
            {
                e.Cancel = true;
                errorPrice.SetError(numPrice, "Цената мора да е поголема од 0!");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Product = new Product(tbName.Text, Convert.ToString(numCode.Value), (float)numPrice.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го откажете додавањето на нов продукт?",
                "Предупредување!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes) Close();
            else return;
        }
    }
}
