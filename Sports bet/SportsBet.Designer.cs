namespace SportsBet
{
    partial class SportsBet
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
            this.lblLstTeams = new System.Windows.Forms.Label();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.gbCreateBilten = new System.Windows.Forms.GroupBox();
            this.mtbCode = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddToBilten = new System.Windows.Forms.Button();
            this.numKoef2 = new System.Windows.Forms.NumericUpDown();
            this.numKoefX = new System.Windows.Forms.NumericUpDown();
            this.numKoef1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lstGames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstTiket = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbDobivka = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numUplata = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTotalKoef = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbCreateBilten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoef2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoefX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoef1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLstTeams
            // 
            this.lblLstTeams.AutoSize = true;
            this.lblLstTeams.Location = new System.Drawing.Point(12, 9);
            this.lblLstTeams.Name = "lblLstTeams";
            this.lblLstTeams.Size = new System.Drawing.Size(96, 13);
            this.lblLstTeams.TabIndex = 0;
            this.lblLstTeams.Text = "Листа на тимови:";
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(15, 25);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstTeams.Size = new System.Drawing.Size(200, 264);
            this.lstTeams.TabIndex = 1;
            // 
            // gbCreateBilten
            // 
            this.gbCreateBilten.Controls.Add(this.mtbCode);
            this.gbCreateBilten.Controls.Add(this.label6);
            this.gbCreateBilten.Controls.Add(this.btnAddTeam);
            this.gbCreateBilten.Controls.Add(this.btnAddToBilten);
            this.gbCreateBilten.Controls.Add(this.numKoef2);
            this.gbCreateBilten.Controls.Add(this.numKoefX);
            this.gbCreateBilten.Controls.Add(this.numKoef1);
            this.gbCreateBilten.Controls.Add(this.label5);
            this.gbCreateBilten.Controls.Add(this.label4);
            this.gbCreateBilten.Controls.Add(this.label3);
            this.gbCreateBilten.Controls.Add(this.label2);
            this.gbCreateBilten.Controls.Add(this.label1);
            this.gbCreateBilten.Location = new System.Drawing.Point(15, 295);
            this.gbCreateBilten.Name = "gbCreateBilten";
            this.gbCreateBilten.Size = new System.Drawing.Size(200, 200);
            this.gbCreateBilten.TabIndex = 2;
            this.gbCreateBilten.TabStop = false;
            this.gbCreateBilten.Text = "Креирај билтен";
            // 
            // mtbCode
            // 
            this.mtbCode.Location = new System.Drawing.Point(58, 119);
            this.mtbCode.Mask = "0000";
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.Size = new System.Drawing.Size(104, 20);
            this.mtbCode.TabIndex = 11;
            this.mtbCode.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCode_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Шифра:";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(6, 171);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(188, 23);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Додади нов тим";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddToBilten
            // 
            this.btnAddToBilten.Location = new System.Drawing.Point(6, 142);
            this.btnAddToBilten.Name = "btnAddToBilten";
            this.btnAddToBilten.Size = new System.Drawing.Size(188, 23);
            this.btnAddToBilten.TabIndex = 8;
            this.btnAddToBilten.Text = "Додади во билтен";
            this.btnAddToBilten.UseVisualStyleBackColor = true;
            this.btnAddToBilten.Click += new System.EventHandler(this.btnAddToBilten_Click);
            // 
            // numKoef2
            // 
            this.numKoef2.DecimalPlaces = 2;
            this.numKoef2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numKoef2.Location = new System.Drawing.Point(27, 98);
            this.numKoef2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numKoef2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKoef2.Name = "numKoef2";
            this.numKoef2.Size = new System.Drawing.Size(120, 20);
            this.numKoef2.TabIndex = 7;
            this.numKoef2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numKoefX
            // 
            this.numKoefX.DecimalPlaces = 2;
            this.numKoefX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numKoefX.Location = new System.Drawing.Point(26, 72);
            this.numKoefX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numKoefX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKoefX.Name = "numKoefX";
            this.numKoefX.Size = new System.Drawing.Size(120, 20);
            this.numKoefX.TabIndex = 6;
            this.numKoefX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numKoef1
            // 
            this.numKoef1.DecimalPlaces = 2;
            this.numKoef1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numKoef1.Location = new System.Drawing.Point(26, 46);
            this.numKoef1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numKoef1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKoef1.Name = "numKoef1";
            this.numKoef1.Size = new System.Drawing.Size(120, 20);
            this.numKoef1.TabIndex = 5;
            this.numKoef1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Постави коефициенти";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Избери два тима од иста држава";
            // 
            // errorCode
            // 
            this.errorCode.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Билтен:";
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(221, 25);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(270, 264);
            this.lstGames.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddGame);
            this.groupBox1.Controls.Add(this.cbTip);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(225, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади натпревар во тикет";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(9, 162);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(142, 23);
            this.btnAddGame.TabIndex = 11;
            this.btnAddGame.Text = "Додади натпревар";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbTip.Location = new System.Drawing.Point(9, 135);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(125, 21);
            this.cbTip.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Избери тип:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(9, 64);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(125, 20);
            this.txtCode.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Шифра:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Избери натпревар од билтенот или внеси шифра:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Тикет:";
            // 
            // lstTiket
            // 
            this.lstTiket.FormattingEnabled = true;
            this.lstTiket.Location = new System.Drawing.Point(497, 25);
            this.lstTiket.Name = "lstTiket";
            this.lstTiket.Size = new System.Drawing.Size(241, 264);
            this.lstTiket.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.tbDobivka);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numUplata);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbTotalKoef);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(497, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 194);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уплати тикет";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(18, 161);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(206, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Печати";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbDobivka
            // 
            this.tbDobivka.Location = new System.Drawing.Point(18, 135);
            this.tbDobivka.Name = "tbDobivka";
            this.tbDobivka.ReadOnly = true;
            this.tbDobivka.Size = new System.Drawing.Size(206, 20);
            this.tbDobivka.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Добивка:";
            // 
            // numUplata
            // 
            this.numUplata.Location = new System.Drawing.Point(18, 83);
            this.numUplata.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numUplata.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUplata.Name = "numUplata";
            this.numUplata.Size = new System.Drawing.Size(206, 20);
            this.numUplata.TabIndex = 18;
            this.numUplata.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUplata.ValueChanged += new System.EventHandler(this.numUplata_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Уплата:";
            // 
            // tbTotalKoef
            // 
            this.tbTotalKoef.Location = new System.Drawing.Point(18, 32);
            this.tbTotalKoef.Name = "tbTotalKoef";
            this.tbTotalKoef.ReadOnly = true;
            this.tbTotalKoef.Size = new System.Drawing.Size(206, 20);
            this.tbTotalKoef.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Вкупно коефициент:";
            // 
            // SportsBet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 507);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstTiket);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstGames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbCreateBilten);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.lblLstTeams);
            this.Name = "SportsBet";
            this.Text = "Спортска обложувалница";
            this.gbCreateBilten.ResumeLayout(false);
            this.gbCreateBilten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKoef2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoefX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKoef1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLstTeams;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.GroupBox gbCreateBilten;
        private System.Windows.Forms.NumericUpDown numKoef2;
        private System.Windows.Forms.NumericUpDown numKoefX;
        private System.Windows.Forms.NumericUpDown numKoef1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddToBilten;
        private System.Windows.Forms.ErrorProvider errorCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbDobivka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numUplata;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTotalKoef;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstTiket;
        private System.Windows.Forms.Label label11;
    }
}

