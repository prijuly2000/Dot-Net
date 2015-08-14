using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingLogin_ok
{
    public partial class Form3 : Form
    {
        QuestionBank qb;
        public Form3()
        {
            InitializeComponent();
            qb = new QuestionBank();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = (qb[0]).ID;
            radioButton1.Text = (qb[0]).OPTION1;
            radioButton2.Text = (qb[0]).OPTION2;
            radioButton3.Text = (qb[0]).OPTION3;
            radioButton4.Text = (qb[0]).OPTION4;
            timer1.Start();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;



        }
        int i=0;
        internal int total=0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == qb[i].ANS)
                {
                    total += qb[i].MARKS;
                }
            }
            else if (radioButton2.Checked)
            {
                if (radioButton2.Text == qb[i].ANS)
                {
                    total += qb[i].MARKS;
                }
            }
            else if (radioButton3.Checked)
            {
                if (radioButton3.Text == qb[i].ANS)
                {
                    total += qb[i].MARKS;
                }
            }
            else if (radioButton4.Checked)
            {
                if (radioButton4.Text == qb[i].ANS)
                {
                    total += qb[i].MARKS;
                }
            }

            i++;
           
            if (i == 5)
            {
                
               // MessageBox.Show("Congrats!!! You have got " + total + " marks");
               
               // if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
               // {
                    this.Hide();
                    timer1.Stop();
                 //   MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                    //System.Windows.Forms.Application.Exit();
                    Form4 f4 = new Form4(this);
                    f4.Show();
               // }

               //else
                {

                    i = 0;
                   // total = 0;
                } 
               

               

            }


            try
            {

                label1.Text = (qb[i]).ID;
                radioButton1.Text = (qb[i]).OPTION1;
                radioButton2.Text = (qb[i]).OPTION2;
                radioButton3.Text = (qb[i]).OPTION3;
                radioButton4.Text = (qb[i]).OPTION4;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                val = 0;
            }
            catch (Exception ex)
            {
                
                Application.Exit();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;

            if (i == 5)
            {
               // timer2.Start();
                MessageBox.Show("Congrats!!! You have got " + total + " marks");
                #region Not Working
                if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                    //System.Windows.Forms.Application.Exit();


                }

                else
                {

                    i = 0;
                    total = 0;
                }
                #endregion



            }
            val = 0;

            try
            {

                label1.Text = (qb[i]).ID;
                radioButton1.Text = (qb[i]).OPTION1;
                radioButton2.Text = (qb[i]).OPTION2;
                radioButton3.Text = (qb[i]).OPTION3;
                radioButton4.Text = (qb[i]).OPTION4;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                
            }
            catch (Exception ex)
            {

                Application.Exit();
            }
            
        }
        int val=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label3.Text = val.ToString();
           
            val++;
            if (val == 60)
            {
                timer1.Stop();
                MessageBox.Show("*****Game Over*****");
                Application.Exit();
            }
        }

       
               
    }
}
