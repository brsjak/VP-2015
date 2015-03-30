using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class Automobiles : Form
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Automobiles()
        {
            InitializeComponent();

            Brand m = new Brand("Mercedes-Benz", 44567);
            Brand s = new Brand("Land Rover", 12456);
            Brand i = new Brand("Maserati", 55678);
            Brand a = new Brand("Audi", 123445);
            Brand u = new Brand("Opel", 55432);
            Brand b = new Brand("BMW", 55671);
            Brand c = new Brand("Aston Martin", 43214);
            Brand l = new Brand("Porche", 44531);
            Brand f = new Brand("Chevrolet", 89567);
            Brand z = new Brand("Cadillac", 34561);
            Brand x = new Brand("Citroen", 14557);
            Brand p = new Brand("Peugeot", 14556);


            markiLst.Items.Add(m);
            markiLst.Items.Add(a);
            markiLst.Items.Add(u);
            markiLst.Items.Add(b);
            markiLst.Items.Add(l);
            markiLst.Items.Add(p);
            markiLst.Items.Add(x);
            markiLst.Items.Add(s);
            markiLst.Items.Add(c);
            markiLst.Items.Add(i);
            markiLst.Items.Add(f);
            markiLst.Items.Add(z);

            loadBrands();
        }

        private void btnAddNewBrand_Click(object sender, EventArgs e)
        {
            NewBrand nb = new NewBrand();
            DialogResult response = nb.ShowDialog();
            if (response == DialogResult.OK)
            {
                if (!containsBrand(nb.Brand))
                {
                    markiLst.Items.Add(nb.Brand);
                    cbBrands.Items.Add(nb.Brand);
                }
                else
                {
                    MessageBox.Show("Таа марка веќе постои!", "Грешка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private bool containsBrand(Brand b)
        {
            foreach (object obj in markiLst.Items)
            {
                Brand s = obj as Brand;
                if (s.Name.Equals(b.Name) || s.Code.Equals(b.Code)) return true;
            }
            return false;
        }
        private void loadBrands()
        {
            foreach (object obj in markiLst.Items)
            {
                Brand b = obj as Brand;
                cbBrands.Items.Add(b);
            }
        }
        private void calculateTotal()
        {
            if (lstCars.Items.Count > 0)
            {/* mora da se proveri dali ima elementi vo listata, ako ne proveri programata kje padne
              * i kje frli exception deka ne postojat elementi, so ovaa proverka toj problem se odbegnuva */
                float avg = 0;
                float sum = 0;
                Automobile najekonomicen = lstCars.Items[0] as Automobile;
                Automobile najskap = lstCars.Items[0] as Automobile;
                foreach (object obj in lstCars.Items)
                {
                    Automobile c = obj as Automobile;
                    sum += c.Spending;
                    if (najekonomicen.Spending > c.Spending) najekonomicen = c;
                    if (najskap.Price < c.Price) najskap = c;
                }
                avg = sum / lstCars.Items.Count;
                tbProsecnaPotrosuvacka.Text = string.Format("{0:0.0} L", avg.ToString());
                tbNajekonomicen.Text = najekonomicen.ToString();
                tbNajskap.Text = najskap.ToString();
            }
            else
            {//svojstvoto Text go vrakja vo default vrednost ako gorniot uslov ne e ispolnet
                tbProsecnaPotrosuvacka.Text = null;
                tbNajekonomicen.Text = null;
                tbNajskap.Text = null;
            }
        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (cbBrands.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете марка!", "Информација!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                MessageBox.Show("Внесете модел!", "Информација!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Brand brand = cbBrands.SelectedItem as Brand;
                Automobile m = new Automobile(brand, tbModel.Text, (float)numPotrosuvacka.Value, Convert.ToInt32(numPrice.Value));
                lstCars.Items.Add(m);
                calculateTotal();
                tbModel.Text = null;
                numPotrosuvacka.Value = 0;
                numPrice.Value = 0;
                cbBrands.SelectedIndex = -1;
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedIndex != -1)
            {
                DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој автомобил!",
                    "Потврда за бришење!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (response == DialogResult.Yes)
                {
                    lstCars.Items.RemoveAt(lstCars.SelectedIndex);
                    calculateTotal();
                }
                else return;
            }
            else
            {
                MessageBox.Show("Немате селектирано автомобил!", "Грешка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void numPotrosuvacka_Validating(object sender, CancelEventArgs e)
        {
            if (numPotrosuvacka.Value > 0) errorSpending.SetError(numPotrosuvacka, null);
            else
            {
                e.Cancel = true;
                errorSpending.SetError(numPotrosuvacka, "Потрошувачката мора е поголема од 0!");
            }
        }

        private void numPrice_Validating(object sender, CancelEventArgs e)
        {
            if (numPrice.Value > 0) errorPrice.SetError(numPrice, null);
            else
            {
                e.Cancel = true;
                errorPrice.SetError(numPrice, "Цената мора е поголема од 0!");
            }
        }
    }
}
