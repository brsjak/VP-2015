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
    public partial class CurrencyConverter : Form
    {
        public AddConvertor Convertor { get; set; }
        public Converter Current { get; set; }
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Convertor = new AddConvertor();
            if (Convertor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstConversions.Items.Add(Convertor.Converter);
                Current = Convertor.Converter;
            }
        }

        private void lstConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            numFrom.Enabled = lstConversions.SelectedIndex != -1;
            numTo.Enabled = lstConversions.SelectedIndex != -1;
            lblFrom.Text = Current.CurrencyFrom;
            lblTo.Text = Current.CurrencyTo;
            numFrom.Value = 1;
            numTo.Value = numFrom.Value * Current.Multiplier;
        }

        private void numTo_ValueChanged(object sender, EventArgs e)
        {
            numFrom.Value = numTo.Value / Current.Multiplier;
        }

        private void numFrom_ValueChanged(object sender, EventArgs e)
        {
            numTo.Value = numFrom.Value * Current.Multiplier;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstConversions.Items.Count == 0)
            {
                MessageBox.Show("Листата со конвертори е празна!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lstConversions.SelectedIndex == -1)
            {
                MessageBox.Show("Немате избрано конвертер кој сакате да го избришете!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Дали сте сигурни?", "Избриши", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != System.Windows.Forms.DialogResult.No)
                {
                    lstConversions.Items.RemoveAt(lstConversions.SelectedIndex);
                }
                else return;
            }
        }
    }
}
