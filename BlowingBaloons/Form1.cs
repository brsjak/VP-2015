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

namespace BlowingBallons
{   /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    public partial class Form1 : Form
    {
        public BallonsScene Scene { get; set; }
        Random rand;
        public string FileName { get; set; }
        public bool IsChanged { get; set; }
        public Form1()
        {
            InitializeComponent();
            New();
            this.DoubleBuffered = true;
        }
        private void New()
        {
            Scene = new BallonsScene();
            rand = new Random();
            Timer t = new Timer();
            t.Tick += new EventHandler(timer_Tick);
            t.Interval = 200;
            t.Start();
            FileName = null;
            IsChanged = false;
            GetTitle();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Scene.Pulse();
            Scene.CheckForExplosions();
            Invalidate(true);
        }
        private void GetTitle()
        {
            this.Text = string.Format("{0}{1}", FileName, IsChanged ? "" : "Untitled*");
        }
        private void SaveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Ballons document (*.balloon)|*.balloon";
                saveFileDialog.Title = "Save a Balloons document";
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
        private void AskToSave()
        {
            DialogResult response = MessageBox.Show("Save changes?", "Save?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (response == System.Windows.Forms.DialogResult.Yes) SaveFile();
            else if (response == System.Windows.Forms.DialogResult.Cancel) return;
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ballons document (*.balloon)|*.balloon";
            openFileDialog.Title = "Open a Balloons document";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openFileDialog.FileName = FileName;
                GetTitle();
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (BallonsScene)formatter.Deserialize(filestream);
                    }
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Cannot read file: " + FileName + "\n");
                    sb.Append("Original message: " + ex.Message);
                    MessageBox.Show(sb.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                    return;
                }
                finally
                {
                    IsChanged = false;
                    Invalidate(true);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Balloon b = new Balloon(Convert.ToInt32(rand.Next(20, 30)), e.Location);
                Scene.AddBalloon(b);
                IsChanged = true;
                Invalidate(true);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total: {0}", Scene.GetBallons());
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsChanged)
            {
                AskToSave();
                Application.Exit();
            }
            else Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripButton_Click(sender, e);
        }
    }
}
