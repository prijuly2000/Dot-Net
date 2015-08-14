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
        public event EventHandler login_click;
        private void button1_Click(object sender, EventArgs e)
        {
           Username = textBox1.Text;
            Passwrod = textBox2.Text;
                login_click(sender, e);
           
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

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
