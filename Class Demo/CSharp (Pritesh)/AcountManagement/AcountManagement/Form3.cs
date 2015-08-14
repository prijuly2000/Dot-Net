using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcountManagement
{
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 f4 = new Form4(this, f2);
                f4.Show();
            }
            else
            {
                Form5 f5 = new Form5(this, f2);
                f5.Show();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
