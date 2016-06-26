namespace Students
{
    partial class StudentFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.numSubjectsPassed = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxAvg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSubjectsPassed)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Листа на студенти:";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(13, 30);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(183, 342);
            this.lstStudents.TabIndex = 1;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(16, 379);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(180, 23);
            this.btnNewStudent.TabIndex = 2;
            this.btnNewStudent.Text = "Нов студент";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(16, 408);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Избриши студент";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // numSubjectsPassed
            // 
            this.numSubjectsPassed.Location = new System.Drawing.Point(202, 30);
            this.numSubjectsPassed.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numSubjectsPassed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSubjectsPassed.Name = "numSubjectsPassed";
            this.numSubjectsPassed.Size = new System.Drawing.Size(154, 20);
            this.numSubjectsPassed.TabIndex = 4;
            this.numSubjectsPassed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Enabled = false;
            this.btnGenerateFile.Location = new System.Drawing.Point(202, 56);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(154, 23);
            this.btnGenerateFile.TabIndex = 5;
            this.btnGenerateFile.Text = "Генерирај досие";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.btnGenerateFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Досие:";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(362, 30);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstFiles.Size = new System.Drawing.Size(198, 342);
            this.lstFiles.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Просек:";
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(460, 382);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 9;
            this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Највисок просек:";
            // 
            // txtMaxAvg
            // 
            this.txtMaxAvg.Location = new System.Drawing.Point(460, 408);
            this.txtMaxAvg.Name = "txtMaxAvg";
            this.txtMaxAvg.ReadOnly = true;
            this.txtMaxAvg.Size = new System.Drawing.Size(100, 20);
            this.txtMaxAvg.TabIndex = 11;
            this.txtMaxAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StudentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 436);
            this.Controls.Add(this.txtMaxAvg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerateFile);
            this.Controls.Add(this.numSubjectsPassed);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label1);
            this.Name = "StudentFile";
            this.Text = "Досие студент";
            ((System.ComponentModel.ISupportInitialize)(this.numSubjectsPassed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.NumericUpDown numSubjectsPassed;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxAvg;
    }
}

