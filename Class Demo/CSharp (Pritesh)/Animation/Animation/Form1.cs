using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int x=20,y=10;
            int i=0;
            Label[] l1 = new Label[str.Length];
            foreach (char ch in str)
            {
                Thread.Sleep(500);
                l1[i] = new Label();
                l1[i].Location = new Point(x,y);
                x += 20;
                
                l1[i].Text = ch.ToString() ;
                this.Update();
                this.Controls.Add(l1[i]);
                i++;
            }
        }
    }
}
