using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBet1_1
{     /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class NewTeam : Form
    {
        public Team Team { get; set; }
        public NewTeam()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
                errorName.SetError(tbName, null);
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името на тимот е задолжително!");
            }
        }

        private void tbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCountry.Text))
                errorCountry.SetError(tbCountry, null);
            else
            {
                e.Cancel = true;
                errorCountry.SetError(tbCountry, "Името на државата е задолжително!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни?", "Откажи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
                Close();
            else return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Team = new Team(tbName.Text, tbCountry.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
