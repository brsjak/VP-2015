using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSerii
{
    public partial class NovTVProgram : Form
    {
        public TV TV { get; set; }
        public NovTVProgram()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorIme.SetError(textBox1, null);
            }
            else {
                e.Cancel = true;
                errorIme.SetError(textBox1, "Името не смее да биде празно!");
            }
        }
        public void num_Validating(object sender, CancelEventArgs e)
        {
            int broj = Convert.ToInt32(numBroj.Value);
            if (broj != 1)
            {
                errorBroj.SetError(numBroj, null);
            }
            else {
                //kje se povika vo glavnata forma, tuka samo go postavuvame error-ot
                e.Cancel = true;
                errorBroj.SetError(numBroj, "Телевизија со овој број веќе постои!");
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult odg = MessageBox.Show("Дали сте сигурни дека да го откажете додадавањето на нов ТВ канал?",
                "Откажи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (odg != DialogResult.No) { Close(); }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            string ime = textBox1.Text;
            int broj = Convert.ToInt32(numBroj.Value);
            TV = new TV(ime, broj);
            DialogResult = DialogResult.OK;
        }
    }
}
