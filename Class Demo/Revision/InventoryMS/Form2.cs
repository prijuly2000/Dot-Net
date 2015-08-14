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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < f1.count; i++)
            {
                listBox1.Items.Add(f1.iv[i]);
            }
        }
    }
}
