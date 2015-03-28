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
{     /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class NewLine : Form
    {
        public Line Line { get; set; }
        public NewLine()
        {
            InitializeComponent();
        }

        private void tbDestinationName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDestinationName.Text))
            {
                errorName.SetError(tbDestinationName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbDestinationName, "Името на линијата е задолжително!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го откажете внесувањето нова линија?", "Внимание",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                Close();
            }
            else { return; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Line = new Line(tbDestinationName.Text, (int)numHour.Value, (int)numMinute.Value, (float)numPrice.Value);
            DialogResult = DialogResult.OK;
        }
    }
}
