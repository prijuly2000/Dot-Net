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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataSet ds;
        public Form4(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=mba91;Initial Catalog=exam;Integrated Security=True;Pooling=False");
           
            //DataSet ds = new DataSet();

            //SqlDataAdapter da = new SqlDataAdapter("select * from ItemMaster", con);
            //da.Fill(ds);

            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            ds.Tables[0].Rows.Add(dr);
            MessageBox.Show("1 Row Inserted");
            
           
        }
    }
}
