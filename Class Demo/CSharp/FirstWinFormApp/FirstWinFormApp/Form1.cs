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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ok Clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + textBox1.Text);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox2.Text);
                int num2 = int.Parse(textBox3.Text);

                Button b1 = sender as Button;
                string str = "";
                if (b1 != null)
                {
                    str = b1.Text;
                    switch (str)
                    {
                        case "+":
                            MessageBox.Show((num1 + num2).ToString());
                            break;
                        case "-":
                            MessageBox.Show((num1 - num2).ToString());
                            break;
                        default:
                            //To terminate the application
                            Application.Exit();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();

            }
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox4.Text);
            textBox4.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            object[] allItems = 
                new object[listBox5.SelectedItems.Count];

            int i = 0;
            foreach (object obj in listBox5.SelectedItems)
            {
                listBox4.Items.Add(obj);
                //We cannot modify the collection
                //on which foreach is performed
                //listBox5.Items.Remove(obj);

                allItems[i++] = obj;
            }

            foreach (object o in allItems)
            {
                listBox5.Items.Remove(o);
            }
        }

       
    }  
}
