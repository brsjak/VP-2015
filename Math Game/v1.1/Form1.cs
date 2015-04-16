using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {  /*
        ** author: Damjan Miloshevski
        ** contact: d.miloshevski@gmail.com;
        ** skype: damjan.milosevski
        ** phone: +38978566409;
        ** web: https://www.facebook.com/damjan.miloshevski
                http://miloshevski.us.to/
        */
        public Equation Equation { get; set; }
        private int counter = 59;
        private int points = 0;
        int i = 0;
        public Player Player { get; set; }
        public List<Player> Players { get; set; }
        public Form1()
        {
            InitializeComponent();
            btnNewGame.Focus();
            Players = new List<Player>();
        }
        private void generateRandom()
        {
            Random op = new Random();
            int operand1 = op.Next(1, 100);
            int operand2 = op.Next(1, 100);
            int oper = op.Next(1, 5);
            char _oper = '+';
            switch (oper)
            {
                case 1:
                    {
                        _oper = '+';//sobiranje
                        break;
                    }
                case 2:
                    {
                        _oper = '-';//odzemanje
                        break;
                    }
                case 3:
                    {
                        _oper = '*';//mnozenje 
                        break;
                    }
                case 4:
                    {
                        _oper = '/';//delenje
                        break;
                    }
                default:
                    _oper = '+';
                    break;
            }

            tbOperand1.Text = Convert.ToString(operand1);
            tbOperand2.Text = Convert.ToString(operand2);
            int o1 = Convert.ToInt32(tbOperand1.Text);
            int o2 = Convert.ToInt32(tbOperand2.Text);
            Equation = new Equation(o1, o2, _oper);

            switch (_oper)
            {
                case '+':
                    {
                        Equation.Result = Math.Abs(o1 + o2);
                        break;
                    }
                case '-':
                    {
                        if (o2 > o1)//za da se izbegne negativen rezultat
                        {
                            Equation.Result = Math.Abs(o2 - o1);
                        }
                        else
                        {
                            Equation.Result = Math.Abs(o1 - o2);
                        }
                        break;
                    }
                case '*':
                    {
                        Equation.Result = Math.Abs(o1 * o2);
                        break;
                    }
                case '/':
                    {

                        if (o2 > o1)//za da se izbegne negativen rezultat
                        {
                            Equation.Result = Math.Abs(o2 / o1);
                        }
                        else
                        {
                            Equation.Result = Math.Abs(o1 / o2);
                        }
                        break;
                    }
                default:
                    Equation.Result = Math.Abs(o1 + o2);
                    break;
            }
            tbResult.Text = Convert.ToString(Equation.Result);
        }
        private void startTimer()
        {
            counter = 59;
            timerRemainingTime = new System.Windows.Forms.Timer();
            timerRemainingTime.Tick += new EventHandler(timerRemainingTime_Tick);
            timerRemainingTime.Interval = 1000;//1 sekunda = 1 000 milisekundi
            timerRemainingTime.Start();
            if (counter < 10)
            {
                lblRemainingTime.Text = "00:0" + counter.ToString();
            }
            else
            {
                lblRemainingTime.Text = "00:" + counter.ToString();
            }
        }
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorName.SetError(tbName, null);
            }
            else
            {
                e.Cancel = true;
                errorName.SetError(tbName, "Името на играчот е задолжително!");
            }
        }

        private void tbOperator_Validating(object sender, CancelEventArgs e)
        {
            if (checkOperator(tbOperator.Text))
            {
                errorOperation.SetError(tbOperator, null);
            }
            else
            {
                e.Cancel = true;
                errorOperation.SetError(tbOperator, "Невалидна операција!");
            }
        }
        private bool checkOperator(string op)
        {
            if (op.Length != 1) return false;
            foreach (object obj in op)
            {
                Char c = Convert.ToChar(obj);
                if (obj.Equals('+') || obj.Equals('-') || obj.Equals('*') || obj.Equals('+') || obj.Equals('/')) return true;
            }
            return false;
        }
        private void timerRemainingTime_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timerRemainingTime.Stop();
                MessageBox.Show("Вашето време истече.\nЗапочнете нова игра. :)", "Информација!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNewGame.Focus();
                Player = new Player(tbName.Text, points);
                Players.Add(Player);
                progBarPoints.Value = 0;
                lblPoints.Text = "0";
                lblRemainingTime.Text = "01:00";
                tbName.Text = null;
                tbResult.Text = null;
                tbOperand1.Text = null;
                tbOperand2.Text = null;

            }
            if (counter < 10)
            {
                lblRemainingTime.Text = "00:0" + counter.ToString();
                progBarRemainingTime.Value = counter;
            }
            else
            {
                lblRemainingTime.Text = "00:" + counter.ToString();
                progBarRemainingTime.Value = counter;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сте сигурни дека сакате да ја исклучите играта?", "Исклучи?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response != DialogResult.No)
            {
                Close();
            }
            else return;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Дали сакате да започнете нова игра?", "Нова игра?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response != DialogResult.No)
            {
                generateRandom();
                points = 0;
                progBarPoints.Value = 0;
                startTimer();
            }
            else return;
        }

        private void btnBestPlayers_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                MessageBox.Show("Играта сеуште не е завршена!", "Најдобри играчи", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                printPlayers();
            }
        }
        private void printPlayers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (object obj in Players)
            {
                Player p = obj as Player;
                i += 1;
                if (Players.Count > 0)
                {
                    Players = Players.OrderByDescending(Player => Player.Points).ToList();
                    sb.Append(i.ToString() + ". ");
                    sb.Append(p.ToString());
                    sb.Append("\n");
                    MessageBox.Show(sb.ToString(), "Најдобри играчи!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Листата на играчи е празна!", "Најдобри играчи!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;
            else
            {
                if (Convert.ToChar(tbOperator.Text).Equals(Equation.Operator))
                {
                    points++;
                    lblPoints.Text = points.ToString();
                    if (points % 10 == 0)
                    {
                        counter += 10;
                    }
                    progBarPoints.Value++;
                }
                tbOperator.Text = null;
                generateRandom();
            }
        }
    }
}
