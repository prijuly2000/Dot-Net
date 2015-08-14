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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form2 f2; Form3 f3;
        public Form4(Form3 f3,Form2 f2)
        {
            InitializeComponent();
            this.f2 = f2;
            this.f3 = f3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.a[int.Parse(textBox1.Text)] = new Saving(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text));

            f2.listBox1.Items.Add(f2.a[int.Parse(textBox1.Text)]);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
