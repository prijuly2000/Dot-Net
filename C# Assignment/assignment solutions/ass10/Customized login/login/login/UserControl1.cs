using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        string uname = "pritesh", pwd = "gandhi";
        public event EventHandler login_click;//make public to make it accessible across the assembly
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == uname && textBox2.Text == pwd)
            {
                MessageBox.Show("Success");
                login_click(sender, e);
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        public string Username
        {
            get { return uname; }
            set { uname = value; }
        }

        public string Passwrod
        {
            get { return pwd; }
            set { pwd = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
