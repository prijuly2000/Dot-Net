using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyLoginControl
{
    public partial class MyLogin : UserControl
    {
        public MyLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "IACSD123" && 
                textBox2.Text == "welcome@123")
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Please try again!!!!");                
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            
        }
    }
}
