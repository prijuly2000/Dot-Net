using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            if (b1.Text == "Start Timer ")
            {
                timer1.Start();
                b1.Text = "Stop Timer ";
            }
            else
            {
                timer1.Stop();
                b1.Text = "Start Timer ";
            }
        }
        int hr = 0, min = 0, sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = hr+" : "+min+" : "+sec;
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hr++;
                }
            }

            
        }
    }
}
