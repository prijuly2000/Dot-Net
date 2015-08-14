using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num1=0; 
        int num2=0;
        

        private void button5_Click(object sender, EventArgs e)
        {
            Button b1 = sender as Button;
            if (flag)
            {
                textBox1.Text = "";
                flag = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            switch (b1.Text)
            {
                case "0":
                    textBox1.Text += "0";
                    break;
                case "1":
                    textBox1.Text += "1";
                    break;
                case "2":
                    textBox1.Text += "2";
                    break;
                case "3":
                    textBox1.Text += "3";
                    break;
                case "4":
                    textBox1.Text += "4";
                    break;
                case "5":
                    textBox1.Text += "5";
                    break;
                case "6":
                    textBox1.Text += "6";
                    break;
                case "7":
                    textBox1.Text += "7";
                    break;
                case "8":
                    textBox1.Text += "8";
                    break;
                case "9":
                    textBox1.Text += "9";
                    break;
                case ".":
                    textBox1.Text += ".";
                    break;

            }

                

        }

        
        string op;
        
        bool flag=false ;
        private void button3_Click(object sender, EventArgs e)
        {
             
            Button b1 = sender as Button;

            if (num1==0)
            {
                num1 = int.Parse(textBox1.Text);
                flag = true;
                op = b1.Text;
            }

            else
            {
                num2 = int.Parse(textBox1.Text);

                flag = true;
                switch (op)
                {
                    case "+":
                        textBox1.Text = (num1 + num2).ToString();
                        num1 = num1 + num2;
                        num2 = 0;
                        break;
                    case "-":
                        textBox1.Text = (num1 - num2).ToString();
                        num1 = num1 - num2;
                        num2 = 0;
                        break;
                    case "*":
                        textBox1.Text = (num1 * num2).ToString();
                        num1 = num1 * num2;
                        num2 = 0;
                        break;
                    case "/":
                        textBox1.Text = (num1 / num2).ToString();
                        num1 = num1 / num2;
                        num2 = 0;
                        break;
                }
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {

            num2 = int.Parse(textBox1.Text);
            
            switch (op)
            {
                case "+":
                    textBox1.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textBox1.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textBox1.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textBox1.Text = (num1 / num2).ToString();
                    break;
                             
                
                
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button b2 = sender as Button;
            switch (b2.Text)
            {
                case "C":
                    textBox1.Text = "0";
                    num1 = num2 = 0;
                    break;
                case "Backspace":
                    string str = textBox1.Text.Trim();
                    int l = str.Length - 1;
                    textBox1.Text = "";
                    for (int i = 0; i < l; i++)
                    {
                        textBox1.Text += str[i];
                    }
                    break;
                case "CE":
                    num1 = int.Parse(textBox1.Text);
                    textBox1.Text = "0";

                    break;
            }
        }

        
   
    }
}
