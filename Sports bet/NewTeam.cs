using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBet
{       /*
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string country = tbCountry.Text;
            string name = tbName.Text;
            Team = new Team(name, country);
            DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Внесете име на тимот!");
            }
            else
            {
                errorName.SetError(tbName, null);
            }
        }

        private void tbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (tbCountry.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorName.SetError(tbCountry, "Внесете име на тимот!");
            }
            else
            {
                errorName.SetError(tbCountry, null);
            }
        }
    }
}
