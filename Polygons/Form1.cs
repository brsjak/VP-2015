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

namespace Polygons
{
    public partial class Form1 : Form
    {
        public Color CurrentColor { get; set; }
        public Point StartPoint { get; set; }
        public Point CurrentPoint { get; set; }
        public Point PreviousPoint { get; set; }
        public PolygonsScene Scene { get; set; }
        public Polygon Polygon { get; set; }
        public bool DrawSquare { get; set; }
        public double DistanceS { get; set; }
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            CurrentColor = Color.Red;
            NewDocument();
            this.DoubleBuffered = true;
        }
        private void NewDocument()
        {
            Scene = new PolygonsScene();
            StartPoint = Point.Empty;
            PreviousPoint = Point.Empty;
            Polygon = null;
            FileName = "Untitled";
            SetTitle();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            if (Polygon != null)
            {
                Polygon.Draw(e.Graphics);
            }
            Scene.Draw(e.Graphics);
            Pen SquarePen = new Pen(Color.Black, 2);
            SquarePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen LinePen = new Pen(Color.Black, 1);
            LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (DrawSquare)
            {
                e.Graphics.DrawRectangle(SquarePen, StartPoint.X - 5, StartPoint.Y - 5, 10, 10);
            }
            if (!StartPoint.IsEmpty)
            {
                e.Graphics.DrawLine(LinePen, PreviousPoint, CurrentPoint);
            }

            SquarePen.Dispose();
            LinePen.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (StartPoint.IsEmpty)
            {
                StartPoint = e.Location;
                Polygon = new Polygon(CurrentColor);
                Polygon.AddPoint(StartPoint);
                PreviousPoint = StartPoint;
            }
            else
            {
                if (DrawSquare)
                {
                    Polygon.IsClosed = true;
                    StartPoint = Point.Empty;
                    PreviousPoint = Point.Empty;
                    DrawSquare = false;
                    if (Polygon.Points.Count >= 3)
                    {
                        Scene.AddPolygon(Polygon);
                    }
                }
                else
                {
                    Polygon.AddPoint(e.Location);
                    PreviousPoint = e.Location;
                }
            }
            Invalidate(true);
        }
        public double Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!StartPoint.IsEmpty)
            {
                DistanceS = Distance(e.Location, StartPoint);
                DrawSquare = (DistanceS <= 25);
            }
            CurrentPoint = e.Location;
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CurrentColor = clr.Color;
            }
        }
        private void AskToSave()
        {
            if (Scene != null && Scene.IsChanged)
            {
                DialogResult response = MessageBox.Show("Save document changes?", "Save document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response != System.Windows.Forms.DialogResult.No)
                {
                    SaveFile();
                }
            }
        }
        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("#Polygons: {0}   {1}, {2}",
                Scene.GetPolygons(), CurrentPoint.X, CurrentPoint.Y);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Polygons doc file (*.pgn)|*.pgn";
                saveFileDialog.Title = "Save Polygon doc";
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
                Scene.IsChanged = false;
                SetTitle();
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Polygons  doc file (*.pgn)|*.pgn";
            openFileDialog.Title = "Open Polygons doc file";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        Scene = (PolygonsScene)formatter.Deserialize(filestream);
                    }
                    SetTitle();
                }
                catch (Exception ex)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("Could not read file: " + FileName);
                    sb.Append("\nOriginal error: " + ex.Message);
                    MessageBox.Show(sb.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }
        private void SetTitle()
        {
            this.Text = string.Format("{0}{1}", FileName, Scene.IsChanged ? "*" : "");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AskToSave();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (Scene != null)
                {
                    Scene.Move(0, 5);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (Scene != null)
                {
                    Scene.Move(0, -5);
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (Scene != null)
                {
                    Scene.Move(5, 0);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                Scene.Move(-5, 0);
            }
            Invalidate(true);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
