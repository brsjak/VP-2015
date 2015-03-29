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
    public partial class AddDestination : Form
    {
        public Destination Destination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void tbNameDestination_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNameDestination.Text))
            {
                errorDestinationName.SetError(tbNameDestination, null);
            }
            else
            {
                e.Cancel = true;
                errorDestinationName.SetError(tbNameDestination, "Името е задолжително!");
            }
        }

        private void numDistance_Validating(object sender, CancelEventArgs e)
        {
            if (numDistance.Value > 0 && numDistance.Value <= 10000)
            {
                errorDistance.SetError(numDistance, null);
            }
            else
            {
                e.Cancel = true;
                errorDistance.SetError(numDistance, "Должината мора да е поголема од 0!");
            }
        }

        private void numPrice_Validating(object sender, CancelEventArgs e)
        {
            if (numPrice.Value > 0 && numPrice.Value <= 5000)
            {
                errorPrice.SetError(numPrice, null);
            }
            else
            {
                e.Cancel = true;
                errorPrice.SetError(numPrice, "Цената мора да е поголема од 0!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int distance = (int)numDistance.Value;
            int price = (int)numPrice.Value;
            Destination = new Destination(tbNameDestination.Text, distance, price);
            DialogResult = DialogResult.OK;
        }
    }
}

