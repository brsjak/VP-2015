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
{  /*
    Author: Damjan Miloshevski
    E-mail: contact@damjanmiloshevski.mk, d.miloshevski@gmail.com
    Web: http://damjanmiloshevski.mk
    Skype: damjan.milosevski
    LinkedIn: https://mk.linkedin.com/in/damjanmiloshevski
    GitHub: https://github.com/damsii
    */
    public partial class StudentFile : Form
    {
        public StudentFile()
        {
            InitializeComponent();
            Student me = new Student("Дамјан", "Милошевски", "123042");
            lstStudents.Items.Add(me);
            loadData();
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = lstStudents.SelectedItem as Student;
            if (s.Subjects.Count > 0) { btnGenerateFile.Enabled = false; loadData(); }
            else { btnGenerateFile.Enabled = true; loadData(); }
        }
        void loadData() {
            if (lstStudents.SelectedIndex != -1) {
                lstFiles.Items.Clear();
                Student s = lstStudents.SelectedItem as Student;
   
                    double avg = 0;
                    double sum = 0;
                    foreach (object obj in s.Subjects)
                    {
                        Subject sbj = obj as Subject;
                        sum += sbj.Grade;
                        lstFiles.Items.Add(sbj);
                    }
                    avg = sum / s.Subjects.Count;
                    s.Average = avg;
                    txtAvg.Text = string.Format("{0:#.##}", s.Average);

                    double maxAvg = s.Average;
                    foreach (Student u in lstStudents.Items)
                    {
                        if (maxAvg < u.Average) { maxAvg = u.Average; }
                    }

                    txtMaxAvg.Text = string.Format("{0:#.##}", maxAvg);
                }
               
            }
        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            int numSubjects = Convert.ToInt32(numSubjectsPassed.Value);
            Student s = lstStudents.SelectedItem as Student;
            s.addSubjects(numSubjects);
            loadData();
        }
        bool studentExist(string idx) {

            foreach (object obj in lstStudents.Items) {
                Student s = obj as Student;
                if (s.Index.Equals(idx)) return true;
            }
            return false;
        }
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            AddStudent nStudent = new AddStudent();
            if (nStudent.ShowDialog() == DialogResult.OK) {
                if (!studentExist(nStudent.Student.Index))
                {
                    lstStudents.Items.Add(nStudent.Student);
                }
                else {
                    MessageBox.Show("Студент со тој индекс веќе постои!", "Додади студент",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                DialogResult response = MessageBox.Show("Дали сте сигурни?", "Избриши студент",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response != DialogResult.No)
                {
                    lstStudents.Items.Remove(lstStudents.SelectedItem);
                    lstFiles.Items.Clear();
                }
            }
            else {
                MessageBox.Show("Немате избрано студент!", "Избриши студент",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
