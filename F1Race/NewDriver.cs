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
    public partial class NewDriver : Form
    {
        public Driver Driver { get; set; }
        public NewDriver()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Driver = new Driver(tbName.Text, Convert.ToInt32(numAge.Value), cbIsFirst.Checked ? true : false);
            DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorName.SetError(tbName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името е задолжително!");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни?", "Откажи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                Close();
            }
            else return;
        }
    }
}
