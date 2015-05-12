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

namespace TickingPies
{
    /*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
    public partial class Form1 : Form
    {
        public PiesScene Scene { get; set; }
        public string FileName { get; set; }
        public Color Color { get; set; }
        public bool IsRunning { get; set; }//flag za animacija
        public Form1()
        {
            InitializeComponent();
            Color = Color.Red;
            this.DoubleBuffered = true;
            IsRunning = false;
            New();
            GetTitle();
        }
        private void New()
        {
            Scene = new PiesScene();
            FileName = "Untitled";
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            Invalidate(true);
        }
        private void GetTitle()
        {
            this.Text = string.Format("{0}", FileName);
        }
        private void AskToSave()
        {
            DialogResult response = MessageBox.Show("Save changes!?", "Save changes!?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response != System.Windows.Forms.DialogResult.No)
            {
                SaveFile();
            }
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Pie document (*.pie)|*.pie";
                saveFileDialog.Title = "Save Pie document";
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
            openFileDialog.Filter = "Pie document (*.pie)|*.pie";
            openFileDialog.Title = "Open Pie document";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (PiesScene)formatter.Deserialize(filestream);
                    }
                    GetTitle();
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Cannot open file: " + FileName);
                    sb.Append("Original message: " + ex.Message);
                    MessageBox.Show(sb.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                    return;
                }
                finally
                {
                    Invalidate(true);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.AddPie(new Pie(e.Location, Color));
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total: {0}", Scene.GetPies());
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color = clr.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.Tick();
            Invalidate(true);
        }

        private void tsStart_Click(object sender, EventArgs e)
        {
            IsRunning = !IsRunning;
            if (IsRunning)
            {
                tsStart.Text = "Старт";
                timer1.Stop();
            }
            else
            {
                tsStart.Text = "Стоп";
                timer1.Start();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Scene != null) {
                AskToSave();
            }
            Application.Exit();
        }
    }
}
