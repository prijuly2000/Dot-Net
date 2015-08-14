using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisconnectedArch
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False");
            SqlCommand cmd = 
                new SqlCommand("select * from Emp", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            //To copy the Primary Key Information
            da.MissingSchemaAction =
                MissingSchemaAction.AddWithKey;
            da.Fill(ds,"MyEmp");
            MessageBox.Show(ds.Tables[0].TableName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = 
                ds.Tables[0].TableName;


           // comboBox1.DataSource = ds;
            //comboBox1.DataBindings = ds.Tables[0].Columns[0]

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows.Find
                (textBox1.Text);
            if (dr != null)
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows.Find
                (textBox7.Text);

            if (dr != null)
            {
                dr[0] = textBox6.Text;
                dr[1] = textBox5.Text;
                dr[2] = textBox4.Text;
                 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].Rows.Find
                (textBox10.Text);
            if (dr != null)
            {
                dr.Delete();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //step1=> Create a new Row
            DataRow dr = ds.Tables[0].NewRow();

            //step2=>Fill the data
            dr[0] = textBox11.Text;
            dr[1] = textBox9.Text;
            dr[2] = textBox8.Text;

            //step3=>Add to the existing DataSet
            ds.Tables[0].Rows.Add(dr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataRow []allRows = ds.Tables[0].Select
                ("basic>=20000 and basic<=40000");
            if (allRows.Length > 0)
            {
                foreach (DataRow dr in allRows)
                {
                    listBox1.Items.Add(dr[1].ToString());
                    comboBox2.Items.Add(dr[1].ToString());
                }
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = 
                new SqlCommandBuilder(da);
            da.Update(ds,"MyEmp");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
