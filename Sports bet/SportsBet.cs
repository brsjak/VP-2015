using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBet
{
    public partial class SportsBet : Form
    { /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
      */
        public SportsBet()
        {
            InitializeComponent();

            Team t = new Team();
            t.Name = "Манчестер Јунајтед";
            t.Country = "Англија";
            lstTeams.Items.Add(t);

            Team t1 = new Team();
            t1.Name = "Барселона";
            t1.Country = "Шпанија";
            lstTeams.Items.Add(t1);

            Team t2 = new Team();
            t2.Name = "Јувентус";
            t2.Country = "Италија";
            lstTeams.Items.Add(t2);

            Team t3 = new Team();
            t3.Name = "Челзи";
            t3.Country = "Англија";
            lstTeams.Items.Add(t3);

            Team t4 = new Team();
            t4.Name = "Манчестер Сити";
            t4.Country = "Англија";
            lstTeams.Items.Add(t4);

            Team t5 = new Team();
            t5.Name = "Баерн Минхен";
            t5.Country = "Германија";
            lstTeams.Items.Add(t5);

            Team t6 = new Team();
            t6.Name = "Шалке 04";
            t6.Country = "Германија";
            lstTeams.Items.Add(t6);

            Team t7 = new Team();
            t7.Name = "Реал Мадрид";
            t7.Country = "Шпанија";
            lstTeams.Items.Add(t7);

            Team t8 = new Team();
            t8.Name = "Париз Сен Жермен";
            t8.Country = "Франција";
            lstTeams.Items.Add(t8);

            Team t9 = new Team();
            t9.Name = "Милан";
            t9.Country = "Италија";
            lstTeams.Items.Add(t9);
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            NewTeam nt = new NewTeam();
            if (nt.ShowDialog() == DialogResult.OK)
            {
                lstTeams.Items.Add(nt.Team);
            }
        }

        private void mtbCode_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbCode.MaskCompleted)
            {
                e.Cancel = true;
                errorCode.SetError(mtbCode, "Внесете четири цифри!");
            }
            else
            {
                errorCode.SetError(mtbCode, null);
            }
        }

        private void btnAddToBilten_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {//gi proveruva site elementi vo formata i vrakja false ako ne se kompletirani, vo sprotivno true
                return;
            }
            if (lstTeams.SelectedItems.Count == 2)
            {
                Game g = new Game();
                g.Code = mtbCode.Text;
                g.Home = lstTeams.SelectedItems[0] as Team;
                g.Guest = lstTeams.SelectedItems[1] as Team;
                g.Coefitients[0] = (float)numKoef1.Value;
                g.Coefitients[1] = (float)numKoefX.Value;
                g.Coefitients[2] = (float)numKoef2.Value;

                if (!sameCountry())
                {
                    MessageBox.Show("Изберете два тима од иста држава!", "Грешка!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                else
                {
                    if (containsTeam(g))
                    {
                        MessageBox.Show("Тој натпревар е веќе внесен!", "Грешка!", MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
                    }
                    else
                    {
                        lstGames.Items.Add(g);
                        numKoef1.Value = 1;
                        numKoefX.Value = 1;
                        numKoef2.Value = 1;
                        lstTeams.ClearSelected();
                        mtbCode.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Изберете точно два тимa!", "Грешка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        bool containsTeam(Game g)
        {
            foreach (object obj in lstGames.Items)
            {
                Game game = obj as Game;
                if (game.Code.Equals(g.Code))
                {
                    return true;
                }
            }
            return false;
        }
        bool containsTicketItem(TicketItem ti)
        {
            foreach (object obj in lstTiket.Items)
            {
                TicketItem tItem = obj as TicketItem;
                if (ti.Game.Code.Equals(tItem.Game.Code))
                {
                    return true;
                }
            }
            return false;
        }
        bool sameCountry()
        {
            Team a = lstTeams.SelectedItems[0] as Team;
            Team b = lstTeams.SelectedItems[1] as Team;
            return a.Country.Equals(b.Country);
        }
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex != -1 && cbTip.SelectedIndex != -1)
            {
                Game g = lstGames.SelectedItem as Game;
                TicketItem ti = new TicketItem();
                ti.Game = g;
                ti.Tip = cbTip.SelectedIndex;
                if (!containsTicketItem(ti))
                {
                    lstTiket.Items.Add(ti);
                    lstGames.ClearSelected();
                    calculateTotal();
                    cbTip.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Тој натпревар е веќе типуван!", "Грешка!", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Немате селектирано натпревар или тип!", "Грешка!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }
        }
        public void calculateTotal()
        {
            float totalCoeficient = 1;
            foreach (object obj in lstTiket.Items)
            {
                TicketItem ti = obj as TicketItem;
                totalCoeficient *= ti.Game.Coefitients[ti.Tip];
            }
            tbTotalKoef.Text = string.Format("{0:0.000}", totalCoeficient.ToString());
            float profit = totalCoeficient * (float)numUplata.Value;
            tbDobivka.Text = string.Format("{0:0.0}", profit);
        }

        private void numUplata_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("За вложени {0:0.0} добивката е {1}",
                numUplata.Value, tbDobivka.Text));
            MessageBox.Show(sb.ToString(), "Информација", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (cbTip.SelectedIndex != -1)
            {
                foreach (object obj in lstGames.Items)
                {
                    Game g = obj as Game;
                    TicketItem ti = new TicketItem();
                    if (txtCode.Text.Equals(Convert.ToString(g.Code)))
                    {
                        ti.Game = g;
                        ti.Tip = cbTip.SelectedIndex;
                        if (!containsTicketItem(ti))
                        {
                            lstTiket.Items.Add(ti);
                            calculateTotal();
                            txtCode.Text = null;
                            cbTip.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Тој натпревар е веќе типуван!", "Грешка!", MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Изберете тип!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
