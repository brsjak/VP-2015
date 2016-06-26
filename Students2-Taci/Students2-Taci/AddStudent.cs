using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students2_Taci
{
    
    public partial class AddStudent : Form
    {
        public Student Student { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                errorName.SetError(textBox1, null);
            }
            else {
                e.Cancel = true;
                errorName.SetError(textBox1, "Името е задолжително!");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                errorSurname.SetError(textBox2, null);
            }
            else
            {
                e.Cancel = true;
                errorSurname.SetError(textBox2, "Името е задолжително!");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!checkIndex(textBox3.Text))
            {
                e.Cancel = true;
                errorIndexs.SetError(textBox3, "Невалиден индекс");
            }
            else {
                errorIndexs.SetError(textBox3, null);
            }
        }
        bool checkIndex(string idx) {
            if (idx.Length < 6) return false;
            char[] digits = idx.ToCharArray();
            for (int i = 0; i < digits.Length; i++)
            {
                if (!char.IsDigit(digits[i])) return false;
            }
            if (digits[0] != '1') return false;

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            int index = Convert.ToInt32(textBox3.Text);
            Student = new Student(name, surname, index);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни?", "Откажи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response != DialogResult.No) { Close(); }
        }
    }
}
