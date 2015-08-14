using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b1=sender as Button;
            if (b1.Text == "Start")
            {
                timer1.Start();
                b1.Text = "Restart";
                button1.Visible = false;

            }
            else
            {
                timer1.Start();
                val = 1;
                button1.Visible = false;
                
            }
        }
        int val=1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"D:\nt-pritz\MS.NET\MS FRAMEWORK\assignment\ass9\3\3\images\" + val + ".jpg";
            val++;
            if (val == 10)
            {
                timer1.Stop();
                button1.Visible = true;
                
            }
        }

        
    }
}
