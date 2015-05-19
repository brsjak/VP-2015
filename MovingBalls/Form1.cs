using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingBalls
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    public partial class Form1 : Form
    {
        public BallsScene Scene { get; set; }
        private static readonly int PADDING = 50;
        public Color Color { get; set; }
        public Timer Timer { get; set; }
        public string FileName { get; set; }
        public bool IsChanged { get; set; }
        public Form1()
        {
            InitializeComponent();
            New();
        }
        private void New()
        {
            Scene = new BallsScene();
            Color = Color.SeaGreen;
            DoubleBuffered = true;
            Timer = new Timer();
            Timer.Interval = 100;
            Timer.Tick += new EventHandler(timer_Tick);
            Timer.Start();
            FileName = "Untitled";
            IsChanged = false;
            GetName();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Scene.Move(Height);
            Invalidate(true);
        }
        private void GetName() { this.Text = string.Format("{0}{1}", FileName, IsChanged ? "*" : ""); }
        private void AskToSave()
        {
            if (IsChanged)
            {
                DialogResult res = MessageBox.Show("Unsaved changes?", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != System.Windows.Forms.DialogResult.No) { SaveFile(); }
            }
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Moving Balls document (*.bls)|.bls";
                saveFileDialog.Title = "Save a Moving Balls document";
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream filestream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(filestream, Scene);
                }
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Moving Balls document (*.bls)|.bls";
            openFileDialog.Title = "Open a Moving Balls document";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        Scene = formatter.Deserialize(filestream) as BallsScene;
                    }
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Cannot read file: " + FileName + "\n");
                    sb.Append("Original message: " + ex.Message);
                    FileName = "Untitled";
                }
                finally
                {
                    GetName();
                    IsChanged = false;
                    Invalidate(true);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.StartMoving(e.Location);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
        }

        private void tsAddBall_Click(object sender, EventArgs e)
        {
            Ball b = new Ball(new Point(PADDING + Scene.GetBalls() * (2 * Ball.RADIUS + 25), Height / 2), Color);
            Scene.AddBall(b);
            IsChanged = true;
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == System.Windows.Forms.DialogResult.OK) { Color = clr.Color; }
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Balls: {0}", Scene.GetBalls());
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                AskToSave();
                New();
            }
            else New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsChanged) { AskToSave(); Application.Exit(); }
            else Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileName = "Untitled";
            saveToolStripButton_Click(sender, e);
        }
    }
}
