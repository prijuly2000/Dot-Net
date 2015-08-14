using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            t = new Team(6);

        }
        int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Emp e1 = new Emp(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text));
            t[i++] = e1;
                      
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        Team t;
        private void button2_Click(object sender, EventArgs e)
        {            
            listBox1.Items.RemoveAt(int.Parse(textBox4.Text));
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < i; j++)
            {
                Emp e2 = (Emp)t[j];
                listBox1.Items.Add(e2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(int.Parse(textBox7.Text), textBox6.Text, int.Parse(textBox5.Text));
            t[i++] = p1;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }


    }
}
