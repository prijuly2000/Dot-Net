using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormCommunication
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            f1.BackColor = Color.DarkBlue;
            f1.button1.BackColor = Color.Wheat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }
    }
}
