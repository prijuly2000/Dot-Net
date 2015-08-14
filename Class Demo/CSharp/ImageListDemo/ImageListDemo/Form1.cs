using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageListDemo
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
            count = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                label1.Text = count.ToString();
                count++;
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Stop();  
            }

            //if (count <= 10)
            //{
            //    label1.Text = count.ToString();
            //    count++;
            //    progressBar1.Value += 1;
            //}
            //else
            //{
            //    timer1.Stop();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Value = 0;
        }
    }
}
