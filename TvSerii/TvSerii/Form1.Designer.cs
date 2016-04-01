namespace TvSerii
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiPrograma = new System.Windows.Forms.Button();
            this.btnDodadiPrograma = new System.Windows.Forms.Button();
            this.numVremetraenje = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTelevizii = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodadiTv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImeTv = new System.Windows.Forms.Label();
            this.txtVremetraenje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstEmisii = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVremetraenje)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiPrograma);
            this.groupBox1.Controls.Add(this.btnDodadiPrograma);
            this.groupBox1.Controls.Add(this.numVremetraenje);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTelevizii);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова програма";
            // 
            // btnIzbrisiPrograma
            // 
            this.btnIzbrisiPrograma.Enabled = false;
            this.btnIzbrisiPrograma.Location = new System.Drawing.Point(181, 191);
            this.btnIzbrisiPrograma.Name = "btnIzbrisiPrograma";
            this.btnIzbrisiPrograma.Size = new System.Drawing.Size(151, 23);
            this.btnIzbrisiPrograma.TabIndex = 7;
            this.btnIzbrisiPrograma.Text = "Избриши програма";
            this.btnIzbrisiPrograma.UseVisualStyleBackColor = true;
            this.btnIzbrisiPrograma.Click += new System.EventHandler(this.btnIzbrisiPrograma_Click);
            // 
            // btnDodadiPrograma
            // 
            this.btnDodadiPrograma.Enabled = false;
            this.btnDodadiPrograma.Location = new System.Drawing.Point(6, 191);
            this.btnDodadiPrograma.Name = "btnDodadiPrograma";
            this.btnDodadiPrograma.Size = new System.Drawing.Size(165, 23);
            this.btnDodadiPrograma.TabIndex = 6;
            this.btnDodadiPrograma.Text = "Додади програма";
            this.btnDodadiPrograma.UseVisualStyleBackColor = true;
            this.btnDodadiPrograma.Click += new System.EventHandler(this.btnDodadiPrograma_Click);
            // 
            // numVremetraenje
            // 
            this.numVremetraenje.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numVremetraenje.Location = new System.Drawing.Point(10, 118);
            this.numVremetraenje.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVremetraenje.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVremetraenje.Name = "numVremetraenje";
            this.numVremetraenje.Size = new System.Drawing.Size(165, 20);
            this.numVremetraenje.TabIndex = 5;
            this.numVremetraenje.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Времетраење (минути):";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(7, 78);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(325, 20);
            this.tbIme.TabIndex = 3;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име:";
            // 
            // cbTelevizii
            // 
            this.cbTelevizii.BackColor = System.Drawing.SystemColors.Window;
            this.cbTelevizii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTelevizii.FormattingEnabled = true;
            this.cbTelevizii.Location = new System.Drawing.Point(7, 37);
            this.cbTelevizii.Name = "cbTelevizii";
            this.cbTelevizii.Size = new System.Drawing.Size(325, 21);
            this.cbTelevizii.TabIndex = 1;
            this.cbTelevizii.SelectedIndexChanged += new System.EventHandler(this.cbTelevizii_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Телевизија:";
            // 
            // btnDodadiTv
            // 
            this.btnDodadiTv.Location = new System.Drawing.Point(19, 320);
            this.btnDodadiTv.Name = "btnDodadiTv";
            this.btnDodadiTv.Size = new System.Drawing.Size(140, 23);
            this.btnDodadiTv.TabIndex = 1;
            this.btnDodadiTv.Text = "Додади ТВ";
            this.btnDodadiTv.UseVisualStyleBackColor = true;
            this.btnDodadiTv.Click += new System.EventHandler(this.btnDodadiTv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImeTv);
            this.groupBox2.Controls.Add(this.txtVremetraenje);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lstEmisii);
            this.groupBox2.Location = new System.Drawing.Point(357, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Програма на ТВ:";
            // 
            // lblImeTv
            // 
            this.lblImeTv.AutoSize = true;
            this.lblImeTv.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImeTv.Location = new System.Drawing.Point(7, 20);
            this.lblImeTv.Name = "lblImeTv";
            this.lblImeTv.Size = new System.Drawing.Size(0, 24);
            this.lblImeTv.TabIndex = 3;
            // 
            // txtVremetraenje
            // 
            this.txtVremetraenje.Location = new System.Drawing.Point(10, 307);
            this.txtVremetraenje.Name = "txtVremetraenje";
            this.txtVremetraenje.ReadOnly = true;
            this.txtVremetraenje.Size = new System.Drawing.Size(285, 20);
            this.txtVremetraenje.TabIndex = 2;
            this.txtVremetraenje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Просечно времетраење:";
            // 
            // lstEmisii
            // 
            this.lstEmisii.FormattingEnabled = true;
            this.lstEmisii.Location = new System.Drawing.Point(7, 61);
            this.lstEmisii.Name = "lstEmisii";
            this.lstEmisii.Size = new System.Drawing.Size(289, 212);
            this.lstEmisii.TabIndex = 0;
            this.lstEmisii.SelectedIndexChanged += new System.EventHandler(this.lstEmisii_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDodadiTv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Тв серии";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVremetraenje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzbrisiPrograma;
        private System.Windows.Forms.Button btnDodadiPrograma;
        private System.Windows.Forms.Button btnDodadiTv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVremetraenje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstEmisii;
        private System.Windows.Forms.Label lblImeTv;
        private System.Windows.Forms.ComboBox cbTelevizii;
        private System.Windows.Forms.NumericUpDown numVremetraenje;
    }
}

