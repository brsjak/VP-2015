using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaForm : Form
    {
        /*
         ** author: Damjan Miloshevski
         ** contact: d.miloshevski@gmail.com;
         ** skype: damjan.milosevski
         ** phone: +38978566409;
         ** web: https://www.facebook.com/damjan.miloshevski
                 http://miloshevski.us.to/
       */

        public float f = 0;

        public PizzaForm()
        {
            InitializeComponent();
            Dessert d = new Dessert();
            d.Name = "Овошна пита";
            d.Price = 80;
            lstDeserti.Items.Add(d);

            Dessert d1 = new Dessert();
            d1.Name = "Сладолед";
            d1.Price = 120;
            lstDeserti.Items.Add(d1);

            Dessert d2 = new Dessert();
            d2.Name = "Торта";
            d2.Price = 160;
            lstDeserti.Items.Add(d2);

        }
        public void calculateTotal()
        {
            // ... vasiot kod ovde ...
            float total = 0;
            tbVkupnoNaplata.Text = tbMala.Text;
            if (rbMala.Checked)
            {
                if (float.TryParse(tbMala.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            else if (rbSredna.Checked)
            {
                if (float.TryParse(tbSredna.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            else
            {
                if (float.TryParse(tbGolema.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            if (cbPeperoni.Checked)
            {
                if (float.TryParse(tbPeperoni.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            if (cbExtraCheese.Checked)
            {
                if (float.TryParse(tbExtraCheese.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            if (cbKetchup.Checked)
            {
                if (float.TryParse(tbKetchup.Text, out f))
                {
                    total += f;
                    tbVkupnoNaplata.Text = total.ToString();
                }
            }
            if (float.TryParse(tbVkupnoCoke.Text, out f))
            {
                total += f;
                tbVkupnoNaplata.Text = total.ToString();
            }
            if (float.TryParse(tbVkupnoBeer.Text, out f))
            {
                total += f;
                tbVkupnoNaplata.Text = total.ToString();
            }
            if (float.TryParse(tbVkupnoJuice.Text, out f))
            {
                total += f;
                tbVkupnoNaplata.Text = total.ToString();
            }
            if (float.TryParse(tbCenaDesert.Text, out f))
            {
                total += f;
                tbVkupnoNaplata.Text = total.ToString();
            }
        }

        private void rbMala_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbSredna_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbGolema_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbPeperoni_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
        private void tbMala_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbMala.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();
        }

        private void tbSredna_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbSredna.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();

        }

        private void tbGolema_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbGolema.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();

        }

        private void tbPeperoni_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbPeperoni.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();
        }

        private void tbExtraCheese_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbExtraCheese.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();
        }

        private void tbKetchup_TextChanged(object sender, EventArgs e)
        {
            float cena = 0;
            float total = 0;
            if (float.TryParse(tbKetchup.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total += cena;
            calculateTotal();
        }
        private void tbKolicinaCoke_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaCoke.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaCoke.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoCoke.Text = total.ToString();
            calculateTotal();
        }
        private void tbCenaCoke_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaCoke.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaCoke.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoCoke.Text = total.ToString();
            calculateTotal();
        }

        private void tbKolicinaJuice_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaJuice.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaJuice.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoJuice.Text = total.ToString();
            calculateTotal();
        }

        private void tbCenaJuice_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaJuice.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaJuice.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoCoke.Text = total.ToString();
            calculateTotal();
        }

        private void tbKolicinaBeer_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaBeer.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaBeer.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoBeer.Text = total.ToString();
            calculateTotal();
        }

        private void tbCenaBeer_TextChanged(object sender, EventArgs e)
        {
            float total = 0;
            float cena = 0;
            float quantity = 0;
            if (float.TryParse(tbCenaBeer.Text, out f))
            {
                cena = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (float.TryParse(tbKolicinaBeer.Text, out f))
            {
                quantity = f;
            }
            else
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = quantity * cena;
            tbVkupnoBeer.Text = total.ToString();
            calculateTotal();
        }
        private void lstDeserti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dessert d = lstDeserti.SelectedItem as Dessert;
            if (d != null)
            {
                tbCenaDesert.Text = Convert.ToString(d.Price);
            }
            calculateTotal();
        }
        private void tbNaplateno_TextChanged(object sender, EventArgs e)
        {
            float naplateno = 0;
            float vkupno = 0;
            double zaVrakjanje = 0;
            if (float.TryParse(tbNaplateno.Text, out f))
            {
                naplateno = f;
            }
            if (float.TryParse(tbVkupnoNaplata.Text, out f))
            {
                vkupno = f;
            }
            if (naplateno > vkupno)
            {
                zaVrakjanje = Math.Abs(naplateno - vkupno);
            }
            else
            {
                zaVrakjanje = Math.Abs(naplateno - vkupno) * -1;
            }
            tbZaVrakjanje.Text = Convert.ToString(zaVrakjanje);

        }
        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            try
            {
                double zaVrakjanje = Convert.ToDouble(tbZaVrakjanje.Text);
                double naplateno = Convert.ToDouble(tbNaplateno.Text);

                if (zaVrakjanje > 0 && naplateno != 0)
                {
                    DialogResult result = MessageBox.Show
                        ("Имате невратен кусур, дали ќе оставите бакшиш!?",
                        "Прашање", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        StringBuilder sb = new StringBuilder();
                        if (rbMala.Checked)
                        {
                            sb.Append("Мала пица");
                            sb.Append("\n");
                        }
                        else if (rbSredna.Checked)
                        {
                            sb.Append("Средна пица");
                            sb.Append("\n");
                        }
                        else
                        {
                            sb.Append("Голема пица");
                            sb.Append("\n");
                        }
                        sb.Append("Додатоци:");
                        sb.Append("\n");
                        if (cbPeperoni.Checked)
                        {
                            sb.Append(cbPeperoni.Text);
                            sb.Append("\n");
                        }
                        if (cbKetchup.Checked)
                        {
                            sb.Append(cbKetchup.Text);
                            sb.Append("\n");
                        }
                        if (cbExtraCheese.Checked)
                        {
                            sb.Append(cbExtraCheese.Text);
                            sb.Append("\n");
                        }
                        sb.Append("Пијалок:\n");
                        float kolicinaCoke = 0;
                        if (float.TryParse(tbKolicinaCoke.Text, out f))
                        {
                            kolicinaCoke = f;
                            if (kolicinaCoke > 0)
                            {
                                sb.Append(Convert.ToString(kolicinaCoke) + " ");
                                sb.Append(lbPijalok1.Text);
                                sb.Append("\n");
                            }
                        }
                        float kolicinaJuice = 0;
                        if (float.TryParse(tbKolicinaJuice.Text, out f))
                        {
                            kolicinaJuice = f;
                            if (kolicinaJuice > 0)
                            {
                                sb.Append(Convert.ToString(kolicinaJuice) + " ");
                                sb.Append(lbPijalok2.Text);
                                sb.Append("\n");
                            }
                        }
                        float kolicinaBeer = 0;
                        if (float.TryParse(tbKolicinaBeer.Text, out f))
                        {
                            kolicinaBeer = f;
                            if (kolicinaBeer > 0)
                            {
                                sb.Append(Convert.ToString(kolicinaBeer) + " ");
                                sb.Append(lbBeer.Text);
                                sb.Append("\n");
                            }
                        }
                        if (lstDeserti.SelectedIndex != -1)
                        {
                            sb.Append("Десерт:");
                            sb.Append("\n");
                            sb.Append(lstDeserti.SelectedItem.ToString());
                            sb.Append("\n");
                            sb.Append("\n");
                        }
                        sb.Append("ВИ БЛАГОДАРИМЕ!! :)");
                        sb.Append("\n");
                        sb.Append("Добар апетит!");
                        DialogResult resultNaracaj = MessageBox.Show(sb.ToString(), "Вашата нарачка",
                            MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (zaVrakjanje == 0 && naplateno != 0)
                {
                    StringBuilder sb = new StringBuilder();
                    if (rbMala.Checked)
                    {
                        sb.Append("Мала пица");
                        sb.Append("\n");
                    }
                    else if (rbSredna.Checked)
                    {
                        sb.Append("Средна пица");
                        sb.Append("\n");
                    }
                    else
                    {
                        sb.Append("Голема пица");
                        sb.Append("\n");
                    }
                    sb.Append("Додатоци:");
                    sb.Append("\n");
                    if (cbPeperoni.Checked)
                    {
                        sb.Append(cbPeperoni.Text);
                        sb.Append("\n");
                    }
                    if (cbKetchup.Checked)
                    {
                        sb.Append(cbKetchup.Text);
                        sb.Append("\n");
                    }
                    if (cbExtraCheese.Checked)
                    {
                        sb.Append(cbExtraCheese.Text);
                        sb.Append("\n");
                    }
                    sb.Append("Пијалок:\n");
                    float kolicinaCoke = 0;
                    if (float.TryParse(tbKolicinaCoke.Text, out f))
                    {
                        kolicinaCoke = f;
                        if (kolicinaCoke > 0)
                        {
                            sb.Append(Convert.ToString(kolicinaCoke) + " ");
                            sb.Append(lbPijalok1.Text);
                            sb.Append("\n");
                        }
                    }
                    float kolicinaJuice = 0;
                    if (float.TryParse(tbKolicinaJuice.Text, out f))
                    {
                        kolicinaJuice = f;
                        if (kolicinaJuice > 0)
                        {
                            sb.Append(Convert.ToString(kolicinaJuice) + " ");
                            sb.Append(lbPijalok2.Text);
                            sb.Append("\n");
                        }
                    }
                    float kolicinaBeer = 0;
                    if (float.TryParse(tbKolicinaBeer.Text, out f))
                    {
                        kolicinaBeer = f;
                        if (kolicinaBeer > 0)
                        {
                            sb.Append(Convert.ToString(kolicinaBeer) + " ");
                            sb.Append(lbBeer.Text);
                            sb.Append("\n");
                        }
                    }
                    if (lstDeserti.SelectedIndex != -1)
                    {
                        sb.Append("Десерт:");
                        sb.Append("\n");
                        sb.Append(lstDeserti.SelectedItem.ToString());
                        sb.Append("\n");
                        sb.Append("\n");
                    }
                    sb.Append("Добар апетит!");
                    DialogResult resultNaracaj = MessageBox.Show(sb.ToString(), "Вашата нарачка",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else if (naplateno == 0)
                {
                    DialogResult resultGreska = MessageBox.Show
                      ("Нарачката не е наплатена!",
                      "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DialogResult resultGreska = MessageBox.Show
                       ("Ве молиме исплатете ја целосната сума пред да ја извршите нарачката!",
                       "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                DialogResult resultGreska = MessageBox.Show
                     ("Внесената вредност не е број!",
                     "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult resultOtkazi = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи",
              MessageBoxButtons.YesNoCancel, // vid na dijalogot 
              MessageBoxIcon.Question); // ikona na dijalogot
            if (resultOtkazi == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultOtkazi == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }
    }
}
