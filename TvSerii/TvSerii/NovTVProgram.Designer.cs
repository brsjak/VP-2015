namespace TvSerii
{
    partial class NovTVProgram
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numBroj = new System.Windows.Forms.NumericUpDown();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.errorIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBroj = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Број:";
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(13, 85);
            this.numBroj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(141, 20);
            this.numBroj.TabIndex = 3;
            this.numBroj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBroj.Validating += new System.ComponentModel.CancelEventHandler(this.num_Validating);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(128, 119);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(99, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(233, 119);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(94, 23);
            this.btnDodadi.TabIndex = 5;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // errorIme
            // 
            this.errorIme.ContainerControl = this;
            // 
            // errorBroj
            // 
            this.errorBroj.ContainerControl = this;
            // 
            // NovTVProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 154);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "NovTVProgram";
            this.Text = "NovTVProgram";
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.ErrorProvider errorIme;
        public System.Windows.Forms.ErrorProvider errorBroj;
        public System.Windows.Forms.NumericUpDown numBroj;
    }
}