using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstWinFormApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                this.groupBox1.BackColor = Color.Green;
            }
            else if (radioButton3.Checked)
            {
                this.button1.BackColor = Color.Blue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            if (b1.Text == "Change Image")
            {
                pictureBox1.ImageLocation = @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Water lilies.jpg";
                b1.Text = "Original";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Sunset.jpg";
                b1.Text = "Change Image";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show
                (monthCalendar1.SelectionStart.ToShortDateString());
        }
    }
}
