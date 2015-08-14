using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void AnimateString()
        {
            string str = textBox1.Text;
            foreach (char ch in str)
            {
                label2.Text += ch;
                label2.Update(); //To flush the o/p to form
                Thread.Sleep(500);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AnimateString();
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            //To start the thread
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
