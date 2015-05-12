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

namespace DrawLines
{
    public partial class Form1 : Form
    {
        LinesDocument linesDoc;
        public string FileName { get; set; }
        public Form1()
        {
            InitializeComponent();
            linesDoc = new LinesDocument(Width, Height);
            DoubleBuffered = true;
            FileName = "Untitled";
            normalToolStripMenuItem.Checked = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            linesDoc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            linesDoc.AddLine(e.Location);
            Invalidate(true);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            linesDoc.UpdateLocation(e.Location);
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                linesDoc.Move(0, -5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                linesDoc.Move(0, 5);
            }
            else if (e.KeyCode == Keys.Left)
            {
                linesDoc.Move(-5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                linesDoc.Move(5, 0);
            }
            Invalidate();
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc.Thickness = 1;
            thinToolStripMenuItem.Checked = true;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc.Thickness = 2;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = true;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc.Thickness = 3;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            if (clr.ShowDialog() == DialogResult.OK)
            {
                linesDoc.CurrentColor = clr.Color;
            }
        }

        private void toolStripStatusLabel1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Lines: {0}\t", linesDoc.GetLines());
        }
        private void toolStripStatusLabel2_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel2.Text = string.Format("X: {0}, Y: {1}",
               linesDoc.CurrentLocation.X, linesDoc.CurrentLocation.Y);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc = new LinesDocument(Width, Height);
            Invalidate(true);
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linesDoc.Positioner = positionerToolStripMenuItem.Checked;
        }
        private void SaveFile()
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Lines doc file (*.lns)|*.lns";
                saveFileDialog.Title = "Save lines doc";
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
                    formatter.Serialize(filestream, linesDoc);
                }
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lines doc file (*.lns)|*.lns";
            openFileDialog.Title = "Open Lines doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        linesDoc = (LinesDocument)formatter.Deserialize(filestream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
    }
}
