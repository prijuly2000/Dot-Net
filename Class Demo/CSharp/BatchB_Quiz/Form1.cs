using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatchB_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void batchB_Login1_loginClk(object sender, EventArgs e)
        {
            MyDll.Emp e1 = new MyDll.Emp("EEE", 101, 10000);
            MessageBox.Show(e1.ToString());

        }

        private void batchB_Login1_Load(object sender, EventArgs e)
        {

        }
    }
}
