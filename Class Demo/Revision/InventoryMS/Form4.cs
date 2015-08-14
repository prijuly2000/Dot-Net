using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryMS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void mySearch1_Load(object sender, EventArgs e)
        {

        }

        private void mySearch1_fileDemo(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void mySearch1_fileError(object sender, EventArgs e)
        {
            MessageBox.Show("Error",
                "Some error has occured...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
