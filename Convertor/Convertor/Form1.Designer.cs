namespace Convertor
{
    partial class CurrencyConverter
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
            this.lstConversions = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Конвертори:";
            // 
            // lstConversions
            // 
            this.lstConversions.FormattingEnabled = true;
            this.lstConversions.Location = new System.Drawing.Point(12, 30);
            this.lstConversions.Name = "lstConversions";
            this.lstConversions.Size = new System.Drawing.Size(120, 225);
            this.lstConversions.TabIndex = 1;
            this.lstConversions.SelectedIndexChanged += new System.EventHandler(this.lstConversions_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(248, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(80, 25);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "FROM:";
            // 
            // numFrom
            // 
            this.numFrom.DecimalPlaces = 3;
            this.numFrom.Enabled = false;
            this.numFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFrom.Location = new System.Drawing.Point(148, 58);
            this.numFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(180, 31);
            this.numFrom.TabIndex = 5;
            this.numFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFrom.ValueChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(281, 92);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(47, 25);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "TO:";
            // 
            // numTo
            // 
            this.numTo.DecimalPlaces = 3;
            this.numTo.Enabled = false;
            this.numTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTo.Location = new System.Drawing.Point(148, 120);
            this.numTo.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(180, 31);
            this.numTo.TabIndex = 7;
            this.numTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTo.ValueChanged += new System.EventHandler(this.numTo_ValueChanged);
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 346);
            this.Controls.Add(this.numTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.numFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstConversions);
            this.Controls.Add(this.label1);
            this.Name = "CurrencyConverter";
            this.Text = "Currency converter v.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConversions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown numTo;
    }
}

