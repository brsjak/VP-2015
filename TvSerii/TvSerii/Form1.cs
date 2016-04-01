using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TvSerii
{
    public partial class Form1 : Form
    {
        /*
        Author: Damjan Miloshevski
        Created on: 29.3.2016
        Phone: +38978566409
        E-mail: d.miloshevski@gmail.com
        Web: https://www.damjanmiloshevski.mk
        Skype: damjan.milosevski
        GitHub: https://github.com/damsii
        LinkedIn: https://mk.linkedin.com/in/damjanmiloshevski
        */
        public Form1()
        {
            InitializeComponent();
            TV sk1 = new TV("SK1", 1);
            cbTelevizii.Items.Add(sk1);
            TV vesti = new TV("24Вести", 2);
            cbTelevizii.Items.Add(vesti);
            TV hbo = new TV("HBO", 3);
            cbTelevizii.Items.Add(hbo);
            /*
            za ComboBox da bide isti kako vo originalniot fajl treba da se smeni property-to
            DropDownStyle na DropDownList
            */

        }

        private void btnDodadiTv_Click(object sender, EventArgs e)
        {
            NovTVProgram nTv = new NovTVProgram();
            if (nTv.ShowDialog() == DialogResult.OK)
            {
                if (!proveriBroj(nTv.TV.Broj))
                {
                    cbTelevizii.Items.Add(nTv.TV);
                }
                else
                {
                    nTv.num_Validating(nTv.numBroj, null);
                    /*se povikuva metododot za validacija na numeric-ot za brojot vo 
                    formata  za dodavanje, a tuka i se isprakja argumentot numBroj (imeto na
                    kontrolata koja ja pristapuvame preku instacata od formata).
                    VAZNO!!: Metodot num_Validating mora da bide public istotaka i numBroj kontrolata
                    za da moze da se pristapat od druga forma. Ova se podesuva vo Properties
                    kje najdete Modifiers i kje go postavite na public, ili vo kodot vo Designer
                    pred funkcijata kje napisete namesto private public, soodvetno i za kontrolata
                    */
                    MessageBox.Show("Веќе постои телевизија со тој број!", "Додади ТВ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool proveriBroj(int broj)
        {
            /*
            @return: vrakja tocno ako brojot vekje postoi vo listata
            */
            foreach (object obj in cbTelevizii.Items)
            {
                TV tv = obj as TV;
                if (tv.Broj == broj) return true;
            }
            return false;
        }
        private void cbTelevizii_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTelevizii.SelectedIndex != -1)
            {
                TV televizija = cbTelevizii.SelectedItem as TV;
                lblImeTv.Text = televizija.Ime;
            }
        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbIme.Text))
            {
                btnDodadiPrograma.Enabled = true;
            }
            else {
                btnDodadiPrograma.Enabled = false;
            }
        }

        private void btnDodadiPrograma_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text;
            int m = Convert.ToInt32(numVremetraenje.Value);
            int minuti = 0;
            int casovi = 0;
            if (m < 60)
            {
                minuti = m;
                casovi = 0;
            }
            else {
                casovi = m / 60;
                minuti = m % 60;
            }
            TVProgram tvProg = new TVProgram(ime, casovi, minuti);
            lstEmisii.Items.Add(tvProg);
            prosecno();
        }

        private void btnIzbrisiPrograma_Click(object sender, EventArgs e)
        {
            if (lstEmisii.SelectedIndex != -1)
            {
                DialogResult odg = MessageBox.Show("Дали сте сигурни?", "Бришење на програма",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odg != DialogResult.No)
                {
                    TVProgram tvProgram = lstEmisii.SelectedItem as TVProgram;
                    lstEmisii.Items.Remove(tvProgram);
                }
            }
        }
        double prosecno()
        {
            /*
            @return:
                Go vrakja prosecnoto vremetraenje vo minuti na site programi na odreden TV kanal
            */
            double prosek = 0;
            double suma = 0;
            foreach (object obj in lstEmisii.Items)
            {
                TVProgram tvProg = obj as TVProgram;
                int m = tvProg.Casovi * 60 + tvProg.Minuti;
                suma += m;
            }
            prosek = suma / lstEmisii.Items.Count;
            txtVremetraenje.Text = prosek.ToString();
            return prosek;
        }
        private void lstEmisii_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnIzbrisiPrograma.Enabled = true;
        }
    }
}
