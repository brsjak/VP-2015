using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busses
{
    public partial class Busses : Form
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Busses()
        {
            InitializeComponent();
            Bus b = new Bus("ЈСП 50", "4432", true);
            Bus k = new Bus("ЈСП 22", "1132", true);
            Bus m = new Bus("Пролетер", "1123", false);
            Bus f = new Bus("Јоцо Турс", "5598", false);
            Bus g = new Bus("Руле Турс", "7785", false);
            Bus c = new Bus("Алпар Туризам, Domino Line", "8865", false);
            Bus y = new Bus("Ниш Експрес", "3250", false);
            Line l = new Line("Битпазар", 12, 33, 35);
            Line z = new Line("Хотел Карпош", 7, 25, 35);
            Line i = new Line("Истанбул", 17, 30, 3580);
            Line a = new Line("Бурса", 23, 30, 6690);
            Line x = new Line("Белград", 6, 30, 2400);
            Line q = new Line("Крива Паланка", 16, 0, 350);
            Line p = new Line("Крива Паланка", 16, 30, 400);
            Line v = new Line("Крива Паланка", 17, 0, 320);
            Line o = new Line("Куманово", 16, 30, 170);
            Line n = new Line("Куманово", 17, 0, 120);

            b.AddLine(l);
            c.AddLine(i);
            c.AddLine(a);
            y.AddLine(x);
            k.AddLine(z);
            m.AddLine(q);
            f.AddLine(o);
            f.AddLine(p);
            g.AddLine(n);
            g.AddLine(v);
            lstBusses.Items.Add(b);
            lstBusses.Items.Add(k);
            lstBusses.Items.Add(m);
            lstBusses.Items.Add(f);
            lstBusses.Items.Add(g);
            lstBusses.Items.Add(c);
            lstBusses.Items.Add(y);

        }

        private void lstBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBusses.SelectedIndex != -1)
            {
                btnDeleteBus.Enabled = true;
                btnAddLine.Enabled = true;
                loadLines();
            }
        }
        public void loadLines()
        {
            tbNajskapaLinija.Clear();
            tbAverageLines.Clear();
            lstLines.Items.Clear();
            Bus b = lstBusses.SelectedItem as Bus;
            if (b != null && b.Lines.Count > 0)
            {
                Line najskapa = b.Lines[0];//prvata destinacija e najskapa na pocetok
                float vkupnoCena = 0;
                foreach (Line l in b.Lines)
                {
                    lstLines.Items.Add(l);
                    if (najskapa.Price < l.Price) najskapa = l;
                    vkupnoCena += l.Price;
                }
                tbNajskapaLinija.Text = najskapa.ToString();
                float average = vkupnoCena / b.Lines.Count;
                tbAverageLines.Text = string.Format("{0:0.0} Ден.", average);
            }
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if (btnAddBus.Enabled)
            {
                NewBus nb = new NewBus();
                DialogResult response = nb.ShowDialog();
                if (response == DialogResult.OK)
                {
                    if (!containsBus(nb.Bus))
                    {
                        lstBusses.Items.Add(nb.Bus);
                        loadLines();
                    }
                    else
                    {
                        MessageBox.Show("Автобус со таа регистарска таблица веќе постои!", "Грешка!",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
        public bool containsBus(Bus b)
        {
            foreach (Bus u in lstBusses.Items)
            {
                if (b.LicencePlate.Equals(u.LicencePlate)) return true;
            }
            return false;
        }
        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if (btnDeleteBus.Enabled)
            {
                DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој автобус?", "Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    lstBusses.Items.RemoveAt(lstBusses.SelectedIndex);
                }
                else { return; }
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            if (btnAddLine.Enabled)
            {
                NewLine nl = new NewLine();
                DialogResult response = nl.ShowDialog();
                if (lstBusses.SelectedIndex != -1)
                {
                    Bus b = lstBusses.SelectedItem as Bus;
                    if (response == DialogResult.OK) { b.AddLine(nl.Line); loadLines(); }
                }
            }
        }
    }
}
