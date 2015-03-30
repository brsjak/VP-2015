using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{     /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class NewBrand : Form
    {
        public Brand Brand { get; set; }
        public NewBrand()
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
                errorName.SetError(tbName, "Името на марката е задолжително!");
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if (!correctCode(tbCode.Text))
            {
                e.Cancel = true;
                errorCode.SetError(tbCode, "Шифрата мора да биде петоцифрен!");
            }
            else errorCode.SetError(tbCode, null);
        }
        private bool correctCode(string code)
        {
            if (code.Length != 5) return false;
            foreach (char c in code)
            {
                if (!Char.IsDigit(c)) return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го откажете внесувањето на новата марка?", "Откажи?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
                Close();
            else return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Brand = new Brand(tbName.Text, Convert.ToInt32(tbCode.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
