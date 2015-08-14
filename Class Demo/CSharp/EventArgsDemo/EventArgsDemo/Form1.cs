using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventArgsDemo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
          
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string str =
               e.X.ToString() + " , " + e.Y.ToString();
            Label l1;
            l1 = new Label();
            l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            l1.Size = new System.Drawing.Size(120, 25);
            
            l1.Location = new Point(e.X, e.Y);
            //l1.ForeColor = Color.White;
            l1.Text = str;
            this.Controls.Add(l1);
        }

        //private void textBox1_KeyDown(object sender, 
        //KeyEventArgs e)
        //{
        //    //MessageBox.Show(e.KeyCode.ToString());
        //    MessageBox.Show(((char)e.KeyValue).ToString());
        //}

        private void textBox1_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                
                
            }
            else
            {
                MessageBox.Show(e.KeyChar.ToString());
                //do not pass the message to application
                e.Handled = true;
            }
            //MessageBox.Show(e.KeyChar.ToString());
        }
    }
}
