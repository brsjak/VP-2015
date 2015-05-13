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

namespace Rectangles
{
    public partial class Form1 : Form
    {/*
     * @author: Damjan Miloshevski
     * contact: +38978566408
     * web: http://miloshevski.us.to
     * skype: damjan.milosevski
     * e-mail: d.miloshevski@gmail.com
     */
        public RectanglesScene Scene { get; set; }
        public Point CurrentPosition { get; set; }
        public Point PreviousPosition { get; set; }
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int width;
        public int height;
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            New();
        }
        private void New()
        {
            Scene = new RectanglesScene();
            PreviousPosition = Point.Empty;
            CurrentPosition = Point.Empty;
            FileName = "Untitled";
            Color = Color.Gold;
            GetTitle();
        }
        private void GetTitle()
        {
            this.Text = FileName;
            Invalidate();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
            if (!PreviousPosition.IsEmpty)
            {
                Pen p = new Pen(Color.Black, 1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(p, X, Y, width, height);
                p.Dispose();

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPosition = e.Location;
            X = PreviousPosition.X;
            Y = PreviousPosition.Y;
            if (X > CurrentPosition.X) X = CurrentPosition.X;
            if (Y > CurrentPosition.Y) Y = CurrentPosition.Y;
            width = Math.Abs(PreviousPosition.X - CurrentPosition.X);//sirina po x
            height = Math.Abs(PreviousPosition.Y - CurrentPosition.Y);//visina po y
            Invalidate(true);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (PreviousPosition.IsEmpty)
                {
                    PreviousPosition = e.Location;
                }
                else
                {
                    Scene.AddRectangle(new Rectangle(new Point(X, Y), width, height, Color));
                    PreviousPosition = Point.Empty;
                    CurrentPosition = Point.Empty;
                }
                Invalidate(true);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Scene.Select(e.Location);
                Invalidate();
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color = clr.Color;
            }
        }
        private void AskToSave()
        {
            if (Scene != null)
            {
                DialogResult response = MessageBox.Show("Save changes?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response != System.Windows.Forms.DialogResult.No) SaveFile();
            }
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "A Rectangle file (*.rect)|*.rect";
                saveFileDialog.Title = "Save a Rectangle file";
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
        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Rectangles: {0}", Scene.GetRectangles());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Scene != null)
            {
                AskToSave();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (Scene != null)
            {
                AskToSave();
                New();
            }
            else
            {
                New();
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "A Rectangle file (*.rect)|*.rect";
            openFileDialog.Title = "Open a Rectangle file";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openFileDialog.FileName = FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (RectanglesScene)formatter.Deserialize(filestream);
                    }
                    GetTitle();
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Cannot read file: " + FileName + "\n");
                    sb.Append("Original message: " + ex.Message);
                    MessageBox.Show(sb.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    Invalidate(true);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Scene.RemoveSelected();
                Invalidate(true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Scene != null)
            {
                AskToSave();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
