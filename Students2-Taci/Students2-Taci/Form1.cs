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
    public partial class Form1 : Form
    {
        public AddStudent AddStudent { get; set; }
        public Form1()
        {
            InitializeComponent();
            setDefaults();
        }
        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            AddStudent = new AddStudent();
            if (AddStudent.ShowDialog() == DialogResult.OK) {
                if (!studentExist(AddStudent.Student))
                {
                    lstStudents.Items.Add(AddStudent.Student);
                }
                else {
                    MessageBox.Show("Студент со таков индекс веќе постои!", "Нов студент", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {   
            if (lstStudents.SelectedIndex != -1)
            {
                Student student = lstStudents.SelectedItem as Student;
                DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да го избришете овој студент?", "Избриши студент", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response != DialogResult.No) {
                    lstStudents.Items.Remove(student);
                }
            }
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
          
            if (lstStudents.SelectedIndex != -1)
            {
                Student s = lstStudents.SelectedItem as Student;
                s.generateFile(Convert.ToInt32(numericUpDown1.Value));
                loadData();
                txtAvg.Text = string.Format("{0:0.##}", s.avg());
                txtExamsPassed.Text = string.Format("{0}", s.examsPassed());
            }
        }
        void loadData() {
            lstSubjects.Items.Clear();
            Student student = lstStudents.SelectedItem as Student;
            if (student != null) {
                foreach (object obj in student.Subjects)
                {
                    Subject sbj = obj as Subject;
                    lstSubjects.Items.Add(sbj);
                }
            }
        }
        bool studentExist(Student student) {
            foreach (object obj in lstStudents.Items) {
                Student std = obj as Student;
                if (student.Index == std.Index) return true;
            }
            return false;
        }
        void setDefaults()
        {
            if (lstStudents.Items.Count == 0)
            {
                lstStudents.Items.Clear();
                btnGenerateFile.Enabled = false;
                numericUpDown1.Enabled = false;
                btnDeleteStudent.Enabled = false;
            }
        }
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerateFile.Enabled = true;
            numericUpDown1.Enabled = true;
            btnDeleteStudent.Enabled = true;
            loadData();
        }
    }
}
