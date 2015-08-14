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
    public partial class Form1 : Form
    {
        internal Inventory iv;
        internal int count;
        public Form1()
        {
            InitializeComponent();
            iv = new Inventory(5);
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item=new Item(int.Parse(textBox1.Text),
                textBox2.Text,double.Parse(textBox3.Text));
            if (count < 5)
            {
                iv[count++] = item;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(iv[i]);
            }
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
        }

        private void seachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
