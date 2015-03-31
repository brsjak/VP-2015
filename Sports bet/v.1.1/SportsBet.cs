using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBet1_1
{     /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
    public partial class SportsBet : Form
    {
        public SportsBet()
        {
            InitializeComponent();

            Team a = new Team("Manchester United", "England");
            Team b = new Team("Arsenal", "England");
            Team c = new Team("Real Madrid", "Spain");
            Team d = new Team("Barcelona", "Spain");

            lstTeams.Items.Add(a);
            lstTeams.Items.Add(b);
            lstTeams.Items.Add(c);
            lstTeams.Items.Add(d);
        }

        private void btnAddToBilten_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;//gi proveruva site elementi vo formata
            if (lstTeams.SelectedItems.Count == 2)
            {
                Team a = lstTeams.SelectedItems[0] as Team;
                Team b = lstTeams.SelectedItems[1] as Team;
                Game g = new Game(a, b, mbtbCode.Text);
                g.Coefitients[0] = (float)numTip1.Value;
                g.Coefitients[1] = (float)numTipX.Value;
                g.Coefitients[2] = (float)numTip2.Value;

                if (sameCountry())
                {
                    if (!sameCode(g))
                    {
                        lstBilten.Items.Add(g);
                        lstTeams.ClearSelected();
                        mbtbCode.Clear();
                        numTip1.ResetText();
                        numTipX.ResetText();
                        numTip2.ResetText();
                    }
                    else
                    {
                        DialogResult response = MessageBox.Show("Овој натпревар е веќе внесен!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (response == DialogResult.OK)
                        {
                            mbtbCode.Clear();
                            mbtbCode.Focus();
                            lstTeams.ClearSelected();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Изберете два тима од иста држава!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstTeams.ClearSelected();
                }
            }
            else
            {
                MessageBox.Show("Изберете 2 тима!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstTeams.ClearSelected();
            }
        }
        private bool sameCode(Game c)
        {
            foreach (object obj in lstBilten.Items)
            {
                Game g = obj as Game;
                if (g.Code.Equals(c.Code)) return true;
            }
            return false;
        }
        private bool sameCountry()
        {
            Team a = lstTeams.SelectedItems[0] as Team;
            Team b = lstTeams.SelectedItems[1] as Team;
            return a.Country.Equals(b.Country);
        }
        private bool containsTeam(Team a)
        {
            foreach (object obj in lstTeams.Items)
            {
                Team b = obj as Team;
                if (a.Name.Equals(b.Name)) return true;
            }
            return false;
        }
        private void mbtbCode_Validating(object sender, CancelEventArgs e)
        {
            if (!mbtbCode.MaskCompleted)
            {
                e.Cancel = true;
                errorCode.SetError(mbtbCode, "Шифрата треба има 4 цифри!");
            }
            else errorCode.SetError(mbtbCode, null);
        }
        private void calculateTotal()
        {
            float totalCoeficient = 1;
            float dobivka = 1;
            foreach (object obj in lstTicket.Items)
            {
                TicketItem t = obj as TicketItem;
                totalCoeficient *= t.Game.Coefitients[t.Tip];//ja zema vrednosta na koeficientot od game i ja stava vo nizata na koeficienti
            }
            dobivka = totalCoeficient * (int)numUplata.Value;
            tbVkupnoKoef.Text = string.Format("{0:0.0000}", totalCoeficient.ToString());
            tbDobivka.Text = string.Format("{0:0.000} ден.", dobivka.ToString());
        }
        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            NewTeam nt = new NewTeam();
            DialogResult response = nt.ShowDialog();
            if (response == DialogResult.OK)
            {
                if (!containsTeam(nt.Team))
                    lstTeams.Items.Add(nt.Team);
                else
                    MessageBox.Show("Тој тим веќе постои!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (lstBilten.SelectedIndex != -1)
            {
                if (cbTip.SelectedIndex != -1)
                {
                    Game g = lstBilten.SelectedItem as Game;
                    TicketItem ti = new TicketItem();
                    ti.Game = g;
                    ti.Tip = cbTip.SelectedIndex;
                    if (!containsItem(ti))
                    {
                        lstTicket.Items.Add(ti);
                        cbTip.SelectedIndex = -1;
                        lstBilten.ClearSelected();
                        calculateTotal();
                    }
                    else
                    {
                        MessageBox.Show("Овој натпревар е веќе типуван!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lstBilten.ClearSelected();
                    }
                }
                else
                    MessageBox.Show("Изберете тип!", "Информација!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTip.Focus();
            }
            else
            {
                MessageBox.Show("Немате избрано натпревар!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool containsItem(TicketItem t)
        {
            foreach (object obj in lstTicket.Items)
            {
                TicketItem i = obj as TicketItem;
                if (i.Game.Code.Equals(t.Game.Code)) return true;
            }
            return false;
        }
        private void tbCode_TextChanged(object sender, EventArgs e)
        {
            if (lstBilten.Items.Count > 0)
            {
                foreach (object obj in lstBilten.Items)
                {
                    Game g = obj as Game;
                    TicketItem item = new TicketItem();
                    if (cbTip.SelectedIndex != -1)
                    {
                        if (g.Code.Equals(tbCode.Text))
                        {
                            item.Game = g;
                            if (!containsItem(item))
                            {
                                lstTicket.Items.Add(item);
                                calculateTotal();
                                tbCode.Text = null;
                            }
                            else
                            {
                                MessageBox.Show("Овој натпревар е веќе типуван!", "Грешка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Изберете тип!", "Информација!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbTip.Focus();
                    }
                }
            }
        }
        private void numUplata_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (lstTicket.Items.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("За уплатени " + (int)numUplata.Value + " ден. , добивката е " + tbDobivka.Text.ToString());
                MessageBox.Show(sb.ToString(), "Вашата уплата", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Тикетот е празен! :(", "Вашата уплата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
