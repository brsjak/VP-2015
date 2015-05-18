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

namespace FlyingBalls
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
        private int GenerateBall { get; set; }
        private Random rand;
        private Timer timer;
        private string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            New();
            GetName();
        }
        private void New()
        {
            Scene = new BallsScene();
            GenerateBall = 0;
            rand = new Random();
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Start();
            FileName = "Untitled";
        }
        private void GetName()
        {
            Text = FileName;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (GenerateBall % 10 == 0)
            {
                int y = rand.Next(2 * Ball.RADIUS, Height - (Ball.RADIUS * 2));
                int x = -Ball.RADIUS;
                Ball b = new Ball(new Point(x, y));
                Scene.AddBall(b);
            }
            GenerateBall++;
            Scene.Move(Width);
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.IsHit(e.Location);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Moving balls document (*.mbdoc)|*.mbdoc";
                saveFileDialog.Title = "Save a moving balls document";
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
                    formatter.Serialize(filestream, FileName);
                }
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Moving balls document (*.mbdoc)|*.mbdoc";
            openFileDialog.Title = "Open a moving balls document";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (BallsScene)formatter.Deserialize(filestream);
                    }
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Cannot read file: " + FileName + "\n");
                    sb.Append("Original message: " + ex.Message);
                    FileName = null;
                }
                finally
                {
                    Invalidate(true);
                }
            }
        }
        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hits: {0} Misses: {1}", Scene.GetHits(), Scene.GetMisses());
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (Scene.IsPaused)
            {//default
                toolStripLabel1.Text = "Continue";
                timer.Stop();
            }
            else
            {
                toolStripLabel1.Text = "Stop";
                timer.Start();
            }
            Scene.IsPaused = !Scene.IsPaused;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }
    }
}
