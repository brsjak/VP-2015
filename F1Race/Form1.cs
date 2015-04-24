using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class Form1 : Form
    { /* @author: Damjan Miloshevski
        #contact: 
            e-mail: d.miloshevski@gmail.com
            phone: +38978566409
            skype: damjan.milosevski
     */
        public Form1()
        {
            InitializeComponent();

            Driver l = new Driver("Lewis Hamilton", 28, true);
            Driver a = new Driver("Fernando Alonso", 32, false);
            Driver c = new Driver("Felipe Massa", 34, false);
            Driver u = new Driver("Kimi Raikonnen", 32, false);

            Lap l1 = new Lap(3, 45);
            Lap l2 = new Lap(2, 40);
            Lap l3 = new Lap(4, 22);
            l.AddLap(l1);
            l.AddLap(l2);
            l.AddLap(l3);

            Lap a1 = new Lap(2, 33);
            Lap a2 = new Lap(6, 55);
            a.AddLap(a1);
            a.AddLap(a2);

            Lap c1 = new Lap(2, 11);
            Lap c2 = new Lap(1, 45);
            c.AddLap(c1);
            c.AddLap(c2);

            Lap u1 = new Lap(1, 15);
            Lap u2 = new Lap(2, 45);
            u.AddLap(u1);
            u.AddLap(u2);

            lstDrivers.Items.Add(l);
            lstDrivers.Items.Add(a);
            lstDrivers.Items.Add(c);
            lstDrivers.Items.Add(u);
        }
        private void loadLaps()
        {
            Driver d = lstDrivers.SelectedItem as Driver;
            lstLaps.Items.Clear();
            if (d != null && d.Laps.Count > 0)
            {
                int limit = (int)numTime.Value;
                Lap najdobar = d.Laps[0];
                int najdobarVreme = najdobar.Minutes * 60 + najdobar.Seconds;
                foreach (object obj in d.Laps)
                {
                    Lap l = obj as Lap;
                    int lVreme = l.Minutes * 60 + l.Seconds;
                    if (limit > 0)
                    {
                        if (najdobarVreme > limit)
                        {
                            lstLaps.Items.Add(l);
                        }
                    }
                    else
                    {
                        lstLaps.Items.Add(l);
                    }
                    if (najdobarVreme > lVreme)
                    {
                        najdobar = l;
                    }
                }
                tbNajbrz.Text = najdobar.ToString();
            }
            else
            {
                lstLaps.Items.Clear();
            }
            if (lstLaps.Items.Count == 0)
            {
                tbNajbrz.Text = null;
            }
        }
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            NewDriver nd = new NewDriver();
            if (nd.ShowDialog() == DialogResult.OK)
            {
                if (!containsDriver(nd.Driver))
                {
                    lstDrivers.Items.Add(nd.Driver);
                }
                else
                {
                    MessageBox.Show("Тој возач постои!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lstDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = lstDrivers.SelectedIndex != -1;
            btnAddLap.Enabled = lstDrivers.SelectedIndex != -1;
            loadLaps();
        }
        private bool containsDriver(Driver d)
        {
            foreach (object obj in lstDrivers.Items)
            {
                Driver s = obj as Driver;
                if (d.Name.Equals(s.Name)) return true;
            }
            return false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled)
            {
                DialogResult response = MessageBox.Show("Дали сте сигурни?", "Избриши?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    lstDrivers.Items.RemoveAt(lstDrivers.SelectedIndex);
                    tbNajbrz.Text = null;
                }
            }
        }
        private void btnAddLap_Click(object sender, EventArgs e)
        {
            Driver d = lstDrivers.SelectedItem as Driver;
            Lap l = new Lap(Convert.ToInt32(numMinutes.Value), Convert.ToInt32(numSeconds.Value));
            d.AddLap(l);
            loadLaps();
        }

        private void numTime_ValueChanged(object sender, EventArgs e)
        {
            loadLaps();
        }

        private void numSeconds_ValueChanged(object sender, EventArgs e)
        {
            int sec = (int)numSeconds.Value;
            if (sec < 0)
            {
                int min = (int)numMinutes.Value;
                if (min > 0)
                {
                    numMinutes.Value--;
                    numSeconds.Value = 59;
                }
                else
                {
                    numSeconds.Value = 0;
                }
            }
            else if (sec > 59)
            {
                numMinutes.Value++;
                numSeconds.Value = 0;
            }
        }
    }
}
