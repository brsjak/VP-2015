using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class AddConvertor : Form
    {
        public Converter Converter { get; set; }
        public AddConvertor()
        {
            InitializeComponent();
        }

        private void tbFrom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFrom.Text))
            {
                e.Cancel = true;
                errorFrom.SetError(tbFrom, "Полето не смее да биде празно!");
            }
            else {
                errorFrom.SetError(tbFrom, null);
            }
        }

        private void tbTo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFrom.Text))
            {
                e.Cancel = true;
                errorTo.SetError(tbTo, "Полето не смее да биде празно!");
            }
            else
            {
                errorTo.SetError(tbTo, null);
            }
        }

        private void numMultiplier_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(numMultiplier.Value) == 0)
            {
                e.Cancel = true;
                errorMultiplier.SetError(numMultiplier, "Вредноста не смее да биде помала или еднаква на 0!");
            }
            else {
                errorMultiplier.SetError(numMultiplier, null);
            }
        }

        private void btnAddConversion_Click(object sender, EventArgs e)
        {
            decimal multiplier = numMultiplier.Value;
            Converter = new Converter(tbFrom.Text,tbTo.Text, multiplier);
            DialogResult = DialogResult.OK;
        }
    }
}
