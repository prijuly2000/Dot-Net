using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericsDemo
{
    public partial class Form1 : Form
    {
        Team<Emp> t;

      //  TeamObj t;

        int i;
        public Form1()
        {
            InitializeComponent();
            t = new Team<Emp>(5);
            //t = new TeamObj(5);
            i = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp e1 = new Emp(textBox1.Text, int.Parse(textBox2.Text), 
                double.Parse(textBox3.Text));
            t[i++] = e1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Player p1 = new Player(textBox6.Text,
            //int.Parse(textBox5.Text), double.Parse(textBox4.Text));
            //t[i++] = p1;
            //textBox6.Clear();
            //textBox5.Clear();
            //textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                listBox1.Items.Add(t[j].ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Emp e1 = (Emp)t[1];
            MessageBox.Show(e1.ToString());

        }

      
    }
}
