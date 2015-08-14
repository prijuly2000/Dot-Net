using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeUtility;

namespace OfficeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp e1 = new Programmer("PPP", 10, 12, 1990, 101, 10000, 10, 100);
            MessageBox.Show(e1.ToString());
        }
    }
}
