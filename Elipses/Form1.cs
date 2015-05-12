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

namespace Elipses
{

    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Point CurrentPosition { get; set; }
        public Point PreviousPosition { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public String FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            NewDrawing();
            timer.Start();
        }
        public void NewDrawing()
        {
            Scene = new Scene();
            PreviousPosition = Point.Empty;
            CurrentPosition = Point.Empty;
            FileName = "Untitled";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
            if (!PreviousPosition.IsEmpty)
            {
                Pen p = new Pen(Color.Gray, 1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(p, X, Y, Width, Height);
                p.Dispose();
            }

        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Elipses doc file (*.elipse)|*.elipse";
                saveFileDialog.Title = "Save an Elipse file";
                saveFileDialog.FileName = FileName;
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
            openFileDialog.Filter = "Elipses doc file (*.elipse)|*.elipse";
            openFileDialog.Title = "Open an Elipses doc file";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                openFileDialog.FileName = FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (Scene)formatter.Deserialize(filestream);
                    }
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Could not read file: " + FileName + "\n");
                    sb.Append("Original error: " + ex.Message);
                    MessageBox.Show(sb.ToString(), "Error reading file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPosition = e.Location;
            X = PreviousPosition.X;
            Y = PreviousPosition.Y;
            if (X > CurrentPosition.X) X = CurrentPosition.X;
            if (Y > CurrentPosition.Y) Y = CurrentPosition.Y;
            Width = Math.Abs(PreviousPosition.X - CurrentPosition.X);
            Height = Math.Abs(PreviousPosition.Y - CurrentPosition.Y);
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (PreviousPosition.IsEmpty)
            {
                PreviousPosition = e.Location;
            }
            else
            {
                Scene.AddElipse(new Point(X, Y), Width, Height);
                PreviousPosition = Point.Empty;
                CurrentPosition = Point.Empty;
            }
            Invalidate(true);
        }
        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Elipses: {0}", Scene.GetElipses());
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDrawing();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewDrawing();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Scene.ChangeColor();
            Invalidate();
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
    }
}
