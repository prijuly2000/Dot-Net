using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(op.FileName);
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            }           

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resizeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; 
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fo = new FontDialog();

            if (fo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fo.Font; 
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog co = new ColorDialog();
            if (co.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = co.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
