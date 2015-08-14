using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginControl
{
    public partial class UserControl1 : UserControl
    {
        string uname, pwd;
        //step 1
        public event EventHandler loginClk;

        public UserControl1()
        {
            InitializeComponent();
            uname = "IACSD";
            pwd = "welcome@123";
        }

        public string UserName
        {
            get
            {
                return uname;
            }
            set
            {
                uname = value;
            }
        }

        public string Password
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == uname && textBox2.Text == pwd)
            {
                MessageBox.Show("Login Successful");
                loginClk(sender, e); //step 3
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
