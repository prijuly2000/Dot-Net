using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace exam
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        DataSet ds;
        public Form5(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            DataRow dr ;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dr = ds.Tables[0].Rows[i];
                comboBox1.Items.Add(dr[1]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows[index] ;
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
          
          
        }
        int index;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             index=comboBox1.SelectedIndex;
            DataRow dr=ds.Tables[0].Rows[index];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString() ;
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();
            textBox4.ReadOnly = true;
        }

       
    }
}
