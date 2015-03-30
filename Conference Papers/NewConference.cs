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
    public partial class NewConference : Form
    {/*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public Conference Conference { get; set; }
        public NewConference()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text)) errorName.SetError(tbName, null);
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името на конференцијата е задолжително!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го откажете внесувањето на нова конференција?",
                "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes) Close();
            else return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Conference = new Conference(tbName.Text, (int)numYear.Value);
            DialogResult = DialogResult.OK;
        }
    }
}
