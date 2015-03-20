namespace PizzaOrder
{
    partial class PizzaForm
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
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.tbGolema = new System.Windows.Forms.TextBox();
            this.tbSredna = new System.Windows.Forms.TextBox();
            this.tbMala = new System.Windows.Forms.TextBox();
            this.gbDodatoci = new System.Windows.Forms.GroupBox();
            this.tbKetchup = new System.Windows.Forms.TextBox();
            this.tbExtraCheese = new System.Windows.Forms.TextBox();
            this.tbPeperoni = new System.Windows.Forms.TextBox();
            this.cbKetchup = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbPeperoni = new System.Windows.Forms.CheckBox();
            this.gbPijalok = new System.Windows.Forms.GroupBox();
            this.tbVkupnoBeer = new System.Windows.Forms.TextBox();
            this.tbVkupnoJuice = new System.Windows.Forms.TextBox();
            this.tbVkupnoCoke = new System.Windows.Forms.TextBox();
            this.tbCenaCoke = new System.Windows.Forms.TextBox();
            this.tbCenaJuice = new System.Windows.Forms.TextBox();
            this.tbCenaBeer = new System.Windows.Forms.TextBox();
            this.tbKolicinaBeer = new System.Windows.Forms.TextBox();
            this.tbKolicinaJuice = new System.Windows.Forms.TextBox();
            this.tbKolicinaCoke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBeer = new System.Windows.Forms.Label();
            this.lbPijalok2 = new System.Windows.Forms.Label();
            this.lbPijalok1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.tbCenaDesert = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstDeserti = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbZaVrakjanje = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.tbVkupnoNaplata = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbDodatoci.SuspendLayout();
            this.gbPijalok.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGolema);
            this.groupBox1.Controls.Add(this.rbSredna);
            this.groupBox1.Controls.Add(this.rbMala);
            this.groupBox1.Controls.Add(this.tbGolema);
            this.groupBox1.Controls.Add(this.tbSredna);
            this.groupBox1.Controls.Add(this.tbMala);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Големина";
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(6, 77);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 8;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbGolema_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(6, 47);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 7;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbSredna_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Checked = true;
            this.rbMala.Location = new System.Drawing.Point(6, 17);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 6;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // tbGolema
            // 
            this.tbGolema.Location = new System.Drawing.Point(164, 77);
            this.tbGolema.Name = "tbGolema";
            this.tbGolema.Size = new System.Drawing.Size(91, 20);
            this.tbGolema.TabIndex = 5;
            this.tbGolema.Text = "500";
            this.tbGolema.TextChanged += new System.EventHandler(this.tbGolema_TextChanged);
            // 
            // tbSredna
            // 
            this.tbSredna.Location = new System.Drawing.Point(164, 48);
            this.tbSredna.Name = "tbSredna";
            this.tbSredna.Size = new System.Drawing.Size(91, 20);
            this.tbSredna.TabIndex = 4;
            this.tbSredna.Text = "300";
            this.tbSredna.TextChanged += new System.EventHandler(this.tbSredna_TextChanged);
            // 
            // tbMala
            // 
            this.tbMala.Location = new System.Drawing.Point(164, 13);
            this.tbMala.Name = "tbMala";
            this.tbMala.Size = new System.Drawing.Size(91, 20);
            this.tbMala.TabIndex = 3;
            this.tbMala.Text = "200";
            this.tbMala.TextChanged += new System.EventHandler(this.tbMala_TextChanged);
            // 
            // gbDodatoci
            // 
            this.gbDodatoci.Controls.Add(this.tbKetchup);
            this.gbDodatoci.Controls.Add(this.tbExtraCheese);
            this.gbDodatoci.Controls.Add(this.tbPeperoni);
            this.gbDodatoci.Controls.Add(this.cbKetchup);
            this.gbDodatoci.Controls.Add(this.cbExtraCheese);
            this.gbDodatoci.Controls.Add(this.cbPeperoni);
            this.gbDodatoci.Location = new System.Drawing.Point(303, 17);
            this.gbDodatoci.Name = "gbDodatoci";
            this.gbDodatoci.Size = new System.Drawing.Size(265, 110);
            this.gbDodatoci.TabIndex = 1;
            this.gbDodatoci.TabStop = false;
            this.gbDodatoci.Text = "Додатоци";
            // 
            // tbKetchup
            // 
            this.tbKetchup.Location = new System.Drawing.Point(173, 77);
            this.tbKetchup.Name = "tbKetchup";
            this.tbKetchup.Size = new System.Drawing.Size(86, 20);
            this.tbKetchup.TabIndex = 5;
            this.tbKetchup.Text = "20";
            this.tbKetchup.TextChanged += new System.EventHandler(this.tbKetchup_TextChanged);
            // 
            // tbExtraCheese
            // 
            this.tbExtraCheese.Location = new System.Drawing.Point(173, 45);
            this.tbExtraCheese.Name = "tbExtraCheese";
            this.tbExtraCheese.Size = new System.Drawing.Size(86, 20);
            this.tbExtraCheese.TabIndex = 5;
            this.tbExtraCheese.Text = "30";
            this.tbExtraCheese.TextChanged += new System.EventHandler(this.tbExtraCheese_TextChanged);
            // 
            // tbPeperoni
            // 
            this.tbPeperoni.Location = new System.Drawing.Point(173, 16);
            this.tbPeperoni.Name = "tbPeperoni";
            this.tbPeperoni.Size = new System.Drawing.Size(86, 20);
            this.tbPeperoni.TabIndex = 4;
            this.tbPeperoni.Text = "40";
            this.tbPeperoni.TextChanged += new System.EventHandler(this.tbPeperoni_TextChanged);
            // 
            // cbKetchup
            // 
            this.cbKetchup.AutoSize = true;
            this.cbKetchup.Location = new System.Drawing.Point(6, 79);
            this.cbKetchup.Name = "cbKetchup";
            this.cbKetchup.Size = new System.Drawing.Size(56, 17);
            this.cbKetchup.TabIndex = 3;
            this.cbKetchup.Text = "Кечап";
            this.cbKetchup.UseVisualStyleBackColor = true;
            this.cbKetchup.CheckedChanged += new System.EventHandler(this.cbKetchup_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(6, 48);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(105, 17);
            this.cbExtraCheese.TabIndex = 1;
            this.cbExtraCheese.Text = "Екстра сирење";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraCheese_CheckedChanged);
            // 
            // cbPeperoni
            // 
            this.cbPeperoni.AutoSize = true;
            this.cbPeperoni.Location = new System.Drawing.Point(6, 19);
            this.cbPeperoni.Name = "cbPeperoni";
            this.cbPeperoni.Size = new System.Drawing.Size(87, 17);
            this.cbPeperoni.TabIndex = 0;
            this.cbPeperoni.Text = "Феферонки";
            this.cbPeperoni.UseVisualStyleBackColor = true;
            this.cbPeperoni.CheckedChanged += new System.EventHandler(this.cbPeperoni_CheckedChanged);
            // 
            // gbPijalok
            // 
            this.gbPijalok.Controls.Add(this.tbVkupnoBeer);
            this.gbPijalok.Controls.Add(this.tbVkupnoJuice);
            this.gbPijalok.Controls.Add(this.tbVkupnoCoke);
            this.gbPijalok.Controls.Add(this.tbCenaCoke);
            this.gbPijalok.Controls.Add(this.tbCenaJuice);
            this.gbPijalok.Controls.Add(this.tbCenaBeer);
            this.gbPijalok.Controls.Add(this.tbKolicinaBeer);
            this.gbPijalok.Controls.Add(this.tbKolicinaJuice);
            this.gbPijalok.Controls.Add(this.tbKolicinaCoke);
            this.gbPijalok.Controls.Add(this.label9);
            this.gbPijalok.Controls.Add(this.label8);
            this.gbPijalok.Controls.Add(this.label7);
            this.gbPijalok.Controls.Add(this.lbBeer);
            this.gbPijalok.Controls.Add(this.lbPijalok2);
            this.gbPijalok.Controls.Add(this.lbPijalok1);
            this.gbPijalok.Location = new System.Drawing.Point(12, 133);
            this.gbPijalok.Name = "gbPijalok";
            this.gbPijalok.Size = new System.Drawing.Size(556, 142);
            this.gbPijalok.TabIndex = 2;
            this.gbPijalok.TabStop = false;
            this.gbPijalok.Text = "Пијалок";
            // 
            // tbVkupnoBeer
            // 
            this.tbVkupnoBeer.Location = new System.Drawing.Point(464, 101);
            this.tbVkupnoBeer.Name = "tbVkupnoBeer";
            this.tbVkupnoBeer.ReadOnly = true;
            this.tbVkupnoBeer.Size = new System.Drawing.Size(69, 20);
            this.tbVkupnoBeer.TabIndex = 11;
            // 
            // tbVkupnoJuice
            // 
            this.tbVkupnoJuice.Location = new System.Drawing.Point(464, 66);
            this.tbVkupnoJuice.Name = "tbVkupnoJuice";
            this.tbVkupnoJuice.ReadOnly = true;
            this.tbVkupnoJuice.Size = new System.Drawing.Size(69, 20);
            this.tbVkupnoJuice.TabIndex = 10;
            // 
            // tbVkupnoCoke
            // 
            this.tbVkupnoCoke.Location = new System.Drawing.Point(464, 35);
            this.tbVkupnoCoke.Name = "tbVkupnoCoke";
            this.tbVkupnoCoke.ReadOnly = true;
            this.tbVkupnoCoke.Size = new System.Drawing.Size(69, 20);
            this.tbVkupnoCoke.TabIndex = 9;
            // 
            // tbCenaCoke
            // 
            this.tbCenaCoke.Location = new System.Drawing.Point(340, 35);
            this.tbCenaCoke.Name = "tbCenaCoke";
            this.tbCenaCoke.Size = new System.Drawing.Size(69, 20);
            this.tbCenaCoke.TabIndex = 6;
            this.tbCenaCoke.Text = "60";
            this.tbCenaCoke.TextChanged += new System.EventHandler(this.tbCenaCoke_TextChanged);
            // 
            // tbCenaJuice
            // 
            this.tbCenaJuice.Location = new System.Drawing.Point(340, 70);
            this.tbCenaJuice.Name = "tbCenaJuice";
            this.tbCenaJuice.Size = new System.Drawing.Size(69, 20);
            this.tbCenaJuice.TabIndex = 7;
            this.tbCenaJuice.Text = "70";
            this.tbCenaJuice.TextChanged += new System.EventHandler(this.tbCenaJuice_TextChanged);
            // 
            // tbCenaBeer
            // 
            this.tbCenaBeer.Location = new System.Drawing.Point(340, 101);
            this.tbCenaBeer.Name = "tbCenaBeer";
            this.tbCenaBeer.Size = new System.Drawing.Size(69, 20);
            this.tbCenaBeer.TabIndex = 8;
            this.tbCenaBeer.Text = "80";
            this.tbCenaBeer.TextChanged += new System.EventHandler(this.tbCenaBeer_TextChanged);
            // 
            // tbKolicinaBeer
            // 
            this.tbKolicinaBeer.Location = new System.Drawing.Point(197, 101);
            this.tbKolicinaBeer.Name = "tbKolicinaBeer";
            this.tbKolicinaBeer.Size = new System.Drawing.Size(69, 20);
            this.tbKolicinaBeer.TabIndex = 5;
            this.tbKolicinaBeer.Text = "0";
            this.tbKolicinaBeer.TextChanged += new System.EventHandler(this.tbKolicinaBeer_TextChanged);
            // 
            // tbKolicinaJuice
            // 
            this.tbKolicinaJuice.Location = new System.Drawing.Point(197, 66);
            this.tbKolicinaJuice.Name = "tbKolicinaJuice";
            this.tbKolicinaJuice.Size = new System.Drawing.Size(69, 20);
            this.tbKolicinaJuice.TabIndex = 4;
            this.tbKolicinaJuice.Text = "0";
            this.tbKolicinaJuice.TextChanged += new System.EventHandler(this.tbKolicinaJuice_TextChanged);
            // 
            // tbKolicinaCoke
            // 
            this.tbKolicinaCoke.Location = new System.Drawing.Point(197, 31);
            this.tbKolicinaCoke.Name = "tbKolicinaCoke";
            this.tbKolicinaCoke.Size = new System.Drawing.Size(69, 20);
            this.tbKolicinaCoke.TabIndex = 3;
            this.tbKolicinaCoke.Text = "0";
            this.tbKolicinaCoke.TextChanged += new System.EventHandler(this.tbKolicinaCoke_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Вкупно";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количина";
            // 
            // lbBeer
            // 
            this.lbBeer.AutoSize = true;
            this.lbBeer.Location = new System.Drawing.Point(6, 108);
            this.lbBeer.Name = "lbBeer";
            this.lbBeer.Size = new System.Drawing.Size(33, 13);
            this.lbBeer.TabIndex = 2;
            this.lbBeer.Text = "Пиво";
            // 
            // lbPijalok2
            // 
            this.lbPijalok2.AutoSize = true;
            this.lbPijalok2.Location = new System.Drawing.Point(6, 73);
            this.lbPijalok2.Name = "lbPijalok2";
            this.lbPijalok2.Size = new System.Drawing.Size(140, 13);
            this.lbPijalok2.TabIndex = 1;
            this.lbPijalok2.Text = "Сок од јаболко / портокал";
            // 
            // lbPijalok1
            // 
            this.lbPijalok1.AutoSize = true;
            this.lbPijalok1.Location = new System.Drawing.Point(6, 38);
            this.lbPijalok1.Name = "lbPijalok1";
            this.lbPijalok1.Size = new System.Drawing.Size(150, 13);
            this.lbPijalok1.TabIndex = 0;
            this.lbPijalok1.Text = " Кока кола / Фанта / Спрајт";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNaracaj);
            this.groupBox3.Controls.Add(this.btnOtkazi);
            this.groupBox3.Controls.Add(this.tbCenaDesert);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lstDeserti);
            this.groupBox3.Location = new System.Drawing.Point(12, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Десерт";
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(149, 75);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(106, 23);
            this.btnNaracaj.TabIndex = 3;
            this.btnNaracaj.Text = "Нарачај";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(149, 104);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(106, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // tbCenaDesert
            // 
            this.tbCenaDesert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbCenaDesert.Location = new System.Drawing.Point(149, 49);
            this.tbCenaDesert.Name = "tbCenaDesert";
            this.tbCenaDesert.ReadOnly = true;
            this.tbCenaDesert.Size = new System.Drawing.Size(106, 20);
            this.tbCenaDesert.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(146, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Цена за десерт:";
            // 
            // lstDeserti
            // 
            this.lstDeserti.DisplayMember = "80";
            this.lstDeserti.FormattingEnabled = true;
            this.lstDeserti.Location = new System.Drawing.Point(9, 19);
            this.lstDeserti.Name = "lstDeserti";
            this.lstDeserti.Size = new System.Drawing.Size(120, 108);
            this.lstDeserti.TabIndex = 0;
            this.lstDeserti.SelectedIndexChanged += new System.EventHandler(this.lstDeserti_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbZaVrakjanje);
            this.groupBox4.Controls.Add(this.tbNaplateno);
            this.groupBox4.Controls.Add(this.tbVkupnoNaplata);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(303, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 134);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Наплата";
            // 
            // tbZaVrakjanje
            // 
            this.tbZaVrakjanje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbZaVrakjanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZaVrakjanje.Location = new System.Drawing.Point(125, 97);
            this.tbZaVrakjanje.Name = "tbZaVrakjanje";
            this.tbZaVrakjanje.ReadOnly = true;
            this.tbZaVrakjanje.Size = new System.Drawing.Size(117, 26);
            this.tbZaVrakjanje.TabIndex = 5;
            this.tbZaVrakjanje.Text = "0";
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNaplateno.Location = new System.Drawing.Point(125, 53);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(117, 26);
            this.tbNaplateno.TabIndex = 3;
            this.tbNaplateno.Text = "0";
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // tbVkupnoNaplata
            // 
            this.tbVkupnoNaplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVkupnoNaplata.Location = new System.Drawing.Point(125, 12);
            this.tbVkupnoNaplata.Name = "tbVkupnoNaplata";
            this.tbVkupnoNaplata.ReadOnly = true;
            this.tbVkupnoNaplata.Size = new System.Drawing.Size(117, 26);
            this.tbVkupnoNaplata.TabIndex = 1;
            this.tbVkupnoNaplata.Text = "200";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "За враќање";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Наплатено:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Вкупно за наплата:";
            // 
            // PizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 428);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPijalok);
            this.Controls.Add(this.gbDodatoci);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PizzaForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Нарачка на пица";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDodatoci.ResumeLayout(false);
            this.gbDodatoci.PerformLayout();
            this.gbPijalok.ResumeLayout(false);
            this.gbPijalok.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGolema;
        private System.Windows.Forms.TextBox tbSredna;
        private System.Windows.Forms.TextBox tbMala;
        private System.Windows.Forms.GroupBox gbDodatoci;
        private System.Windows.Forms.CheckBox cbKetchup;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.CheckBox cbPeperoni;
        private System.Windows.Forms.TextBox tbKetchup;
        private System.Windows.Forms.TextBox tbExtraCheese;
        private System.Windows.Forms.TextBox tbPeperoni;
        private System.Windows.Forms.GroupBox gbPijalok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbBeer;
        private System.Windows.Forms.Label lbPijalok2;
        private System.Windows.Forms.Label lbPijalok1;
        private System.Windows.Forms.TextBox tbCenaCoke;
        private System.Windows.Forms.TextBox tbCenaJuice;
        private System.Windows.Forms.TextBox tbCenaBeer;
        private System.Windows.Forms.TextBox tbKolicinaBeer;
        private System.Windows.Forms.TextBox tbKolicinaJuice;
        private System.Windows.Forms.TextBox tbKolicinaCoke;
        private System.Windows.Forms.TextBox tbVkupnoBeer;
        private System.Windows.Forms.TextBox tbVkupnoJuice;
        private System.Windows.Forms.TextBox tbVkupnoCoke;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDeserti;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox tbCenaDesert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbZaVrakjanje;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.TextBox tbVkupnoNaplata;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
    }
}

