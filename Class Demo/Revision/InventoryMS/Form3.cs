using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductLib;

namespace InventoryMS
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3()
        {
            InitializeComponent();
        }
         public Form3(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(int.Parse(textBox1.Text),
               textBox2.Text, double.Parse(textBox3.Text));
            if (f1.count < 5)
            {
                f1.iv[f1.count++] = item;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
