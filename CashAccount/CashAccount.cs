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
    public partial class CashAccount : Form
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public CashAccount()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            DialogResult response = np.ShowDialog();
            if (response == DialogResult.OK)
            {
                if (!containsProduct(np.Product)) lstProducts.Items.Add(np.Product);
                else
                {
                    MessageBox.Show("Производ со таков код веќе постои!", "Грешка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToAccount.Enabled = lstProducts.SelectedIndex != -1;
            numQuantity.Enabled = lstProducts.SelectedIndex != -1;
        }

        private void btnAddToAccount_Click(object sender, EventArgs e)
        {
            if (btnAddToAccount.Enabled)
            {
                if (lstProducts.SelectedIndex != -1)
                {
                    Product p = lstProducts.SelectedItem as Product;
                    AccountItem a = new AccountItem(p, (int)numQuantity.Value);
                    lstItems.Items.Add(a);
                    calculateTotal();
                }
            }
        }
        public void calculateTotal()
        {
            float total = 0;
            float totalWithTax = 0;

            foreach (object obj in lstItems.Items)
            {
                AccountItem i = obj as AccountItem;
                total += (i.Product.Price * i.Quantity);
            }
            totalWithTax = total * (float)(1 + numTax.Value / 100);
            //danokot se dobiva so pretvaranje na procentot + 1
            tbTotal.Text = string.Format("{0:#.##}", total.ToString());
            tbPaycheck.Text = string.Format("{0:#.##}", totalWithTax.ToString());
        }
        public bool containsProduct(Product p)
        {
            foreach (object obj in lstProducts.Items)
            {
                Product k = obj as Product;
                if (p.Code.Equals(k.Code)) return true;
            }
            return false;
        }
        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteItem.Enabled = lstItems.SelectedIndex != -1;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (btnDeleteItem.Enabled)
            {
                if (lstItems.SelectedIndex != -1)
                {
                    DialogResult response = MessageBox.Show("Избриши ставка?", "Предупредување!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (response == DialogResult.Yes) lstItems.Items.RemoveAt(lstItems.SelectedIndex);
                    else return;
                    calculateTotal();

                }
            }
        }

        private void numTax_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
    }
}
