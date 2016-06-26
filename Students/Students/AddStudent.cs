using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    /*
    Author: Damjan Miloshevski
    E-mail: contact@damjanmiloshevski.mk, d.miloshevski@gmail.com
    Web: http://damjanmiloshevski.mk
    Skype: damjan.milosevski
    LinkedIn: https://mk.linkedin.com/in/damjanmiloshevski
    GitHub: https://github.com/damsii
    */

    public partial class AddStudent : Form
    {
        public Student Student { get; set; }
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtIme.Text;
            string lastName = txtPrezime.Text;
            string index = txtIndex.Text;
            Student = new Student(name, lastName, index);
            DialogResult = DialogResult.OK;
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                errorName.SetError(txtIme, "Името е задолжително!");
            }
            else {
                errorName.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorLastName.SetError(txtPrezime, null);
            }
            else {
                e.Cancel = true;
                errorLastName.SetError(txtPrezime, "Презимето е задолжително!");
            }
        }

        private void txtIndex_Validating(object sender, CancelEventArgs e)
        {
            string idx = txtIndex.Text;
            if (!string.IsNullOrWhiteSpace(idx) && isValidIndex(idx))
            {
                errorIndex.SetError(txtIndex, null);
            }
            else {
                e.Cancel = true;
                errorIndex.SetError(txtIndex, "Невалиден индекс!");
            }
        }
        bool isValidIndex(string idx) {
            foreach (Char c in idx) {
                if (!Char.IsDigit(c)) return false;
            }
            if (idx.Length != 6) return false;
            if (!idx[0].Equals('1')) return false;

            return true;
        }
    }
}
