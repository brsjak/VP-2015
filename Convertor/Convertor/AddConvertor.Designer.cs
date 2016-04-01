namespace Convertor
{
    partial class AddConvertor
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
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numMultiplier = new System.Windows.Forms.NumericUpDown();
            this.btnAddConversion = new System.Windows.Forms.Button();
            this.btnCancelConversion = new System.Windows.Forms.Button();
            this.errorFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMultiplier = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Од:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(12, 30);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(169, 20);
            this.tbFrom.TabIndex = 1;
            this.tbFrom.Validating += new System.ComponentModel.CancelEventHandler(this.tbFrom_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Во:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(12, 79);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(169, 20);
            this.tbTo.TabIndex = 3;
            this.tbTo.Validating += new System.ComponentModel.CancelEventHandler(this.tbTo_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Множач:";
            // 
            // numMultiplier
            // 
            this.numMultiplier.DecimalPlaces = 3;
            this.numMultiplier.Increment = new decimal(new int[] {
            100,
            0,
            0,
            196608});
            this.numMultiplier.Location = new System.Drawing.Point(13, 131);
            this.numMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMultiplier.Name = "numMultiplier";
            this.numMultiplier.Size = new System.Drawing.Size(120, 20);
            this.numMultiplier.TabIndex = 5;
            this.numMultiplier.Validating += new System.ComponentModel.CancelEventHandler(this.numMultiplier_Validating);
            // 
            // btnAddConversion
            // 
            this.btnAddConversion.Location = new System.Drawing.Point(12, 202);
            this.btnAddConversion.Name = "btnAddConversion";
            this.btnAddConversion.Size = new System.Drawing.Size(75, 23);
            this.btnAddConversion.TabIndex = 6;
            this.btnAddConversion.Text = "Додади";
            this.btnAddConversion.UseVisualStyleBackColor = true;
            this.btnAddConversion.Click += new System.EventHandler(this.btnAddConversion_Click);
            // 
            // btnCancelConversion
            // 
            this.btnCancelConversion.Location = new System.Drawing.Point(144, 202);
            this.btnCancelConversion.Name = "btnCancelConversion";
            this.btnCancelConversion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelConversion.TabIndex = 7;
            this.btnCancelConversion.Text = "Откажи";
            this.btnCancelConversion.UseVisualStyleBackColor = true;
            // 
            // errorFrom
            // 
            this.errorFrom.ContainerControl = this;
            // 
            // errorMultiplier
            // 
            this.errorMultiplier.ContainerControl = this;
            // 
            // errorTo
            // 
            this.errorTo.ContainerControl = this;
            // 
            // AddConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 237);
            this.Controls.Add(this.btnCancelConversion);
            this.Controls.Add(this.btnAddConversion);
            this.Controls.Add(this.numMultiplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Name = "AddConvertor";
            this.Text = "AddConvertor";
            ((System.ComponentModel.ISupportInitialize)(this.numMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMultiplier;
        private System.Windows.Forms.Button btnAddConversion;
        private System.Windows.Forms.Button btnCancelConversion;
        private System.Windows.Forms.ErrorProvider errorFrom;
        private System.Windows.Forms.ErrorProvider errorMultiplier;
        private System.Windows.Forms.ErrorProvider errorTo;
    }
}