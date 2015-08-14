using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Next_previous_disconnectedArch
{
    public partial class Form1 : Form
    {
        DataSet ds;
        int n=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlDataAdapter da;
        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=comp48;Initial Catalog=database1;Integrated Security=True;Pooling=False";

            da = new SqlDataAdapter("select * from emp",con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds);
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr=ds.Tables[0].Rows[0];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            n = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lastindex=ds.Tables[0].Rows.Count;
            DataRow dr = ds.Tables[0].Rows[lastindex-1];
            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            n = ds.Tables[0].Rows.Count-1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = ds.Tables[0].Rows.Find(textBox1.Text);
                index = ds.Tables[0].Rows.IndexOf(dr);
                dr = ds.Tables[0].Rows[index - 1];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                n--;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
            }
            
        }
        int index;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = ds.Tables[0].Rows.Find(textBox1.Text);
                index = ds.Tables[0].Rows.IndexOf(dr);
                dr = ds.Tables[0].Rows[index + 1];
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                
                n++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Add")
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                button5.Text = "Insert";
            }
            else
            {

                DataRow dr = ds.Tables[0].NewRow();
                dr[0] = textBox1.Text;
                dr[1] = textBox2.Text;
                dr[2] = textBox3.Text;
                ds.Tables[0].Rows.Add(dr);
                button5.Text = "Add";
            }
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            DataRow dr=ds.Tables[0].Rows[n]; ;
                   
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows[n];
            dr.Delete();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds);            

        }
    }
}
