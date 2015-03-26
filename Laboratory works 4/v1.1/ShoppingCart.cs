using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShoppingCart_v1_1
{
    public partial class ShoppingCart : Form
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public float f = 0;
        public ShoppingCart()
        {
            InitializeComponent();

            Product p = new Product();
            p.Name = "Млеко";
            p.Category = "Храна";
            p.Price = 48;
            lstProducts.Items.Add(p);

            Product p1 = new Product();
            p1.Name = "Месо";
            p1.Category = "Храна";
            p1.Price = 296;
            lstProducts.Items.Add(p1);

            Product p2 = new Product();
            p2.Name = "Вино";
            p2.Category = "Пијалоци";
            p2.Price = 480;
            lstProducts.Items.Add(p2);

            Product p3 = new Product();
            p3.Name = "Пиво";
            p3.Category = "Пијалоци";
            p3.Price = 110;
            lstProducts.Items.Add(p3);

            Product p4 = new Product();
            p4.Name = "Паста за заби";
            p4.Category = "Хигиена";
            p4.Price = 96;
            lstProducts.Items.Add(p4);
        }

        private void btnEmptyLstProducts_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?",
               "Испразни ја листата?",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                lstProducts.Items.Clear();
                tbProductName.Text = "";
                tbProductCategory.Text = "";
                tbProductPrice.Text = "";
            }
            else
            {
                return;
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                Product p = lstProducts.SelectedItem as Product;
                tbProductName.Text = p.Name;
                tbProductCategory.Text = p.Category;
                tbProductPrice.Text = string.Format("{0:00.00}", p.Price);
            }
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?",
               "Испразни ја кошничката?",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                lstCart.Items.Clear();
                tbTotal.Text = "0.00";
            }
            else
            {
                return;
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex != -1)
            {
                DialogResult option = MessageBox.Show("Дали сте сигурни дека сакате да го избришете производот "
                    + lstProducts.SelectedItem.ToString() + "?", "Предупредување", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (option == DialogResult.Yes)
                {
                    lstProducts.Items.RemoveAt(lstProducts.SelectedIndex);
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Немате селектирано ниеден производ!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            float total = 0;
            if (lstCart.SelectedIndex != -1)
            {
                ProductItem pr = lstCart.SelectedItem as ProductItem;
                string name = pr.Product.Name;
                float quantity = pr.Quantity;
                DialogResult option = MessageBox.Show("Дали сте сигурни дека сакате да го избришете производот "
                    + name + " со количина " + quantity + " од кошничката?", "Предупредување!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (option == DialogResult.Yes)
                {
                    ProductItem pi = lstCart.SelectedItem as ProductItem;
                    if (float.TryParse(tbTotal.Text, out f))
                    {
                        total = f;
                        float subsum = pi.Quantity * pi.Product.Price;
                        total -= subsum;
                    }
                    lstCart.Items.Remove(pi);
                    tbTotal.Text = total.ToString();
                }
                else
                {
                    return;
                }
            }
            else if (lstCart.Items.Count == 0)
            {
                DialogResult res = MessageBox.Show("Кошничката е празна!", "Информација",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult res = MessageBox.Show("Немате селектирано ниеден производ!", "Грешка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            NewProduct np = new NewProduct();
            if (np.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!containsProduct(np.Product))
                {
                    lstProducts.Items.Add(np.Product);
                }
                else
                {
                    DialogResult res = MessageBox.Show("Производ со такво име веќе постои!", "Грешка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        public bool containsProduct(Product p)
        {
            foreach (object obj in lstProducts.Items)
            {
                Product p1 = obj as Product;
                if (p.Name.Equals(p1.Name))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            float total = 0;
            if (lstProducts.SelectedIndex != -1)
            {
                if (numericQuantity.Value > 0)
                {
                    ProductItem pi = new ProductItem();
                    Product p = lstProducts.SelectedItem as Product;
                    pi.Product = p;
                    pi.Quantity = (float)numericQuantity.Value;
                    lstCart.Items.Add(pi);
                    foreach (ProductItem pr in lstCart.Items)
                    {
                        float totalQuantityPrice = pr.Product.Price * pr.Quantity;
                        total += totalQuantityPrice;
                    }
                    tbTotal.Text = total.ToString();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Количината на избраниот производ е 0!", "Грешка!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            else
            {
                DialogResult res = MessageBox.Show("Немате селектирано ниеден производ!", "Грешка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

