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
{   /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class NewBus : Form
    {
        public Bus Bus { get; set; }
        public NewBus()
        {
            InitializeComponent();
        }

        private void tbBusName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbBusName.Text))
            {
                errorName.SetError(tbBusName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbBusName, "Името на автобусот е задолжително!");
            }
        }

        private void tbLicencePlate_Validating(object sender, CancelEventArgs e)
        {
            if (correctPlate(tbLicencePlate.Text))
            {
                errorLP.SetError(tbLicencePlate, null);
            }
            else
            {
                e.Cancel = true;
                errorLP.SetError(tbLicencePlate, "Регистрацијата мора да биде четирицифрен број!");
            }
        }
        public bool correctPlate(string code)
        {
            if (code.Length != 4) return false;
            foreach (char c in code)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го откажете внесувањето нов автобус?", "Внимание",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                Close();
            }
            else { return; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bus = new Bus(tbBusName.Text, tbLicencePlate.Text, cbIsLocal.Checked ? true : false);
            DialogResult = DialogResult.OK;
        }
    }
}
