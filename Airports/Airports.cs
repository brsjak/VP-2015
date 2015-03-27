using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class Airports : Form
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Airports()
        {
            InitializeComponent();

            Airport a = new Airport();
            a.Name = "Alexander The Great Airport";
            a.City = "Skopje";
            a.Short = "SKP";
            a.AddDestination(new Destination("Istanbul", 850, 145));
            Airport i = new Airport();
            i.Name = "Atatürk Airport";
            i.City = "Istanbul";
            i.Short = "IST";
            i.AddDestination(new Destination("Skopje", 850, 145));
            i.AddDestination(new Destination("New York City", 3521, 720));
            i.AddDestination(new Destination("Moscow", 1520, 350));
            i.AddDestination(new Destination("Barcelona", 1100, 450));
            i.AddDestination(new Destination("Chicago", 5986, 380));
            Airport l = new Airport();
            l.Name = "Heathrow Airport";
            l.City = "London";
            l.Short = "LHR";
            l.AddDestination(new Destination("Toronto", 1300, 480));
            Airport n = new Airport();
            n.Name = "John F. Kennedy International Airport";
            n.Short = "JFK";
            n.City = "New York City";
            n.AddDestination(new Destination("Sydney", 2250, 536));
            Airport f = new Airport();
            f.Name = "Frankfurt Airport";
            f.City = "Frankfurt";
            f.Short = "FRA";
            f.AddDestination(new Destination("Skopje", 1120, 280));
            Airport y = new Airport();
            y.Name = "Schiphol Airport";
            y.City = "Amsterdam";
            y.Short = "AMS";
            y.AddDestination(new Destination("Moscow", 480, 320));
            Airport c = new Airport();
            c.Name = "Charles de Gaulle Airport";
            c.City = "Paris";
            c.Short = "CDG";
            c.AddDestination(new Destination("Melbourne", 6850, 1450));

            lstAirports.Items.Add(a);
            lstAirports.Items.Add(i);
            lstAirports.Items.Add(l);
            lstAirports.Items.Add(n);
            lstAirports.Items.Add(c);
            lstAirports.Items.Add(f);
            lstAirports.Items.Add(y);
        }

        private void lstAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteAirport.Enabled = lstAirports.SelectedIndex != -1;
            btnAddDestination.Enabled = lstAirports.SelectedIndex != -1;
            loadDestinations();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            NewAirport na = new NewAirport();
            DialogResult res = na.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (containsAirport(na.Airport))
                {
                    MessageBox.Show("Тој аеродром веќе го има!", "Грешка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    lstAirports.Items.Add(na.Airport);
                }
            }
        }
        public bool containsAirport(Airport a)
        {
            foreach (Airport i in lstAirports.Items)
            {
                if (i.Short.Equals(a.Short)) return true;
            }
            return false;
        }
        public void loadDestinations()
        {
            lstDestinations.Items.Clear();
            tbNajskapaDestinacija.Clear();
            tbProsecnaDolzinaDest.Clear();
            Airport a = lstAirports.SelectedItem as Airport;
            if (a != null && a.Destinations.Count > 0)
            {
                Destination najskapa = a.Destinations[0];
                float vkupnoDistanca = 0;
                foreach (Destination destination in a.Destinations)
                {
                    lstDestinations.Items.Add(destination);
                    if (destination.Price > najskapa.Price)
                    {
                        najskapa = destination;
                    }
                    vkupnoDistanca += destination.Distance;
                }
                tbNajskapaDestinacija.Text = najskapa.ToString();
                float prosekDistanca = vkupnoDistanca / lstDestinations.Items.Count;
                tbProsecnaDolzinaDest.Text = string.Format("{0:#.00} km", prosekDistanca.ToString());
            }
        }
        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if (btnDeleteAirport.Enabled)
            {
                DialogResult result = MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој аеродром?","Внимание!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lstAirports.Items.RemoveAt(lstAirports.SelectedIndex);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            if (btnAddDestination.Enabled)
            {
                AddDestination ad = new AddDestination();
                DialogResult res = ad.ShowDialog();
                if (res == DialogResult.OK)
                {
                    Airport a = lstAirports.SelectedItem as Airport;
                    a.AddDestination(ad.Destination);
                    loadDestinations();
                }
            }

        }
    }
}
