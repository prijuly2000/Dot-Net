using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatchB_LoginControl
{
    public partial class BatchB_Login : UserControl
    {
        public event EventHandler loginClk;
        public event EventHandler cancelClk;

        string uname, pwd;
        public BatchB_Login()
        {
            InitializeComponent();
            pwd = "Welcome@123";
            uname = "IACSD";
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
                MessageBox.Show("Success");
                loginClk(sender, e);

            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
