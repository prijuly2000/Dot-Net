using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstWinFormApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        bool flag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Time Up!");

            if (flag)
            {
                pictureBox1.ImageLocation = @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Water lilies.jpg";
                flag = false;
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\sunset.jpg";
                flag = true;
            }
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
