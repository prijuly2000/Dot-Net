using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankOfIndia;

namespace AcountManagement
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        Form2 f2;
        public Form6(Form2 f)
        {
            InitializeComponent();
            f2 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID=int.Parse(textBox1.Text);
            int index = 0; ;
            foreach (Account a1 in f2.a)
            {
                if (a1.id == ID)
                {
                    break;
                }
                index++;
            }
            f2.listBox1.Items.RemoveAt(index);
        }


    }
}
