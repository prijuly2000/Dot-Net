using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePadApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void existingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Existing is selected");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sunset");
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = 
                FormWindowState.Minimized;
        }
        private void twoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = 
               FormWindowState.Maximized;
        }
        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = 
                FormWindowState.Normal;
        }

        private void recentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            
            if (op.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(op.FileName);
                richTextBox1.LoadFile(op.FileName, 
                    RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sv.FileName, 
                    RichTextBoxStreamType.PlainText);
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;                
            }
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
                //richTextBox1.SelectedText
            }
        }
    }
}
