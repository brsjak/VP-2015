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
{   /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class NewAirport : Form
    {
        public Airport Airport { get; set; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (tbCity.Text.Trim().Length > 0)
            {
                errorCity.SetError(tbCity, null);
            }
            else
            {
                e.Cancel = true;
                errorCity.SetError(tbCity, "Градот е задолжителен!");
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length > 0)
            {
                errorName.SetError(tbName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името е задолжително!");
            }
        }


        private void tbShort_Validating(object sender, CancelEventArgs e)
        {
            if (correctCode(tbShort.Text))
            {
                errorShort.SetError(tbShort, null);
            }
            else
            {
                e.Cancel = true;
                errorCity.SetError(tbShort, "Кратенката треба да има точно 3 големи букви!");
            }
        }
        public bool correctCode(string code)
        {
            if (code.Length != 3) return false;
            foreach (char c in code)
            {
                if (Char.IsLower(c)) return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Airport = new Airport(tbShort.Text, tbName.Text, tbCity.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
