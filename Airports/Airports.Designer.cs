namespace Airports
{
    partial class Airports
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
            this.lstAirports = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.Дестинација = new System.Windows.Forms.Label();
            this.lstDestinations = new System.Windows.Forms.ListBox();
            this.gbDestinations = new System.Windows.Forms.GroupBox();
            this.tbProsecnaDolzinaDest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNajskapaDestinacija = new System.Windows.Forms.TextBox();
            this.gbDestinations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // lstAirports
            // 
            this.lstAirports.FormattingEnabled = true;
            this.lstAirports.Location = new System.Drawing.Point(12, 25);
            this.lstAirports.Name = "lstAirports";
            this.lstAirports.Size = new System.Drawing.Size(268, 238);
            this.lstAirports.TabIndex = 1;
            this.lstAirports.SelectedIndexChanged += new System.EventHandler(this.lstAirports_SelectedIndexChanged);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(12, 278);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(268, 23);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Додади аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Enabled = false;
            this.btnDeleteAirport.Location = new System.Drawing.Point(12, 326);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(268, 23);
            this.btnDeleteAirport.TabIndex = 3;
            this.btnDeleteAirport.Text = "Избриши аеродром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Enabled = false;
            this.btnAddDestination.Location = new System.Drawing.Point(12, 371);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(268, 23);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // Дестинација
            // 
            this.Дестинација.AutoSize = true;
            this.Дестинација.Location = new System.Drawing.Point(283, 9);
            this.Дестинација.Name = "Дестинација";
            this.Дестинација.Size = new System.Drawing.Size(69, 13);
            this.Дестинација.TabIndex = 5;
            this.Дестинација.Text = "Дестинации";
            // 
            // lstDestinations
            // 
            this.lstDestinations.FormattingEnabled = true;
            this.lstDestinations.Location = new System.Drawing.Point(286, 25);
            this.lstDestinations.Name = "lstDestinations";
            this.lstDestinations.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDestinations.Size = new System.Drawing.Size(288, 238);
            this.lstDestinations.TabIndex = 6;
            // 
            // gbDestinations
            // 
            this.gbDestinations.Controls.Add(this.tbProsecnaDolzinaDest);
            this.gbDestinations.Controls.Add(this.label4);
            this.gbDestinations.Controls.Add(this.label3);
            this.gbDestinations.Controls.Add(this.tbNajskapaDestinacija);
            this.gbDestinations.Location = new System.Drawing.Point(286, 278);
            this.gbDestinations.Name = "gbDestinations";
            this.gbDestinations.Size = new System.Drawing.Size(288, 116);
            this.gbDestinations.TabIndex = 7;
            this.gbDestinations.TabStop = false;
            this.gbDestinations.Text = "Дестинации";
            // 
            // tbProsecnaDolzinaDest
            // 
            this.tbProsecnaDolzinaDest.Location = new System.Drawing.Point(6, 74);
            this.tbProsecnaDolzinaDest.Name = "tbProsecnaDolzinaDest";
            this.tbProsecnaDolzinaDest.ReadOnly = true;
            this.tbProsecnaDolzinaDest.Size = new System.Drawing.Size(264, 20);
            this.tbProsecnaDolzinaDest.TabIndex = 11;
            this.tbProsecnaDolzinaDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа дестинација";
            // 
            // tbNajskapaDestinacija
            // 
            this.tbNajskapaDestinacija.Location = new System.Drawing.Point(6, 35);
            this.tbNajskapaDestinacija.Name = "tbNajskapaDestinacija";
            this.tbNajskapaDestinacija.ReadOnly = true;
            this.tbNajskapaDestinacija.Size = new System.Drawing.Size(264, 20);
            this.tbNajskapaDestinacija.TabIndex = 9;
            this.tbNajskapaDestinacija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Airports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.gbDestinations);
            this.Controls.Add(this.lstDestinations);
            this.Controls.Add(this.Дестинација);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lstAirports);
            this.Controls.Add(this.label1);
            this.Name = "Airports";
            this.Text = "Аеродроми";
            this.gbDestinations.ResumeLayout(false);
            this.gbDestinations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAirports;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.Label Дестинација;
        private System.Windows.Forms.ListBox lstDestinations;
        private System.Windows.Forms.GroupBox gbDestinations;
        private System.Windows.Forms.TextBox tbProsecnaDolzinaDest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNajskapaDestinacija;
    }
}

