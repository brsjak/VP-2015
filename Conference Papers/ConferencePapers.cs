using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferencePapers
{
    public partial class ConferencePapers : Form
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        List<Conference> Conferences;
        int selectedYear;//za da se vcituvaat konferenciite vo listata po godina
        public ConferencePapers()
        {
            InitializeComponent();
            Conferences = new List<Conference>();
            Conference i1 = new Conference("ICT Innovation", 2014);
            Conference i2 = new Conference("ICT Innovation", 2013);
            Conference a = new Conference("ADBIS", 2014);
            Conference c = new Conference("CIIT", 2013);
            Conference c2 = new Conference("CIIT", 2012);
            Conferences.Add(i1);
            Conferences.Add(i2);
            Conferences.Add(a);
            Conferences.Add(c);
            Conferences.Add(c2);
            selectedYear = -1;
            loadConferences(selectedYear);
            loadYears();
        }
        private void loadConferences(int year)
        {
            lstConferences.Items.Clear();
            foreach (object obj in Conferences)
            {
                Conference c = obj as Conference;
                if (year == -1 || c.Year.Equals(year))
                {
                    lstConferences.Items.Add(c);
                }
            }
        }
        private void loadYears()
        {
            cbYear.Items.Clear();
            cbYear.Items.Add(-1);
            foreach (object obj in Conferences)
            {
                Conference c = obj as Conference;
                if (!cbYear.Items.Contains(c.Year))//za da ne se povtoruvaat godinite vo combobox-ot
                {
                    cbYear.Items.Add(c.Year);
                }
            }
        }
        private void btnAddConference_Click(object sender, EventArgs e)
        {
            NewConference nc = new NewConference();
            DialogResult response = nc.ShowDialog();
            if (response == DialogResult.OK) Conferences.Add(nc.Conference);
            loadConferences(selectedYear);
            loadYears();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedYear = (int)cbYear.SelectedItem;
            loadConferences(selectedYear);
        }

        private void btnDeleteConference_Click(object sender, EventArgs e)
        {
            if (lstConferences.SelectedIndex != -1)
            {
                Conference d = lstConferences.SelectedItem as Conference;
                DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа конференција?", "Избриши конференција?",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes) Conferences.Remove(d);
                else return;
                loadConferences(selectedYear);

            }
        }
    }
}
