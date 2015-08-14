using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ConnectedDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {               

                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(*) from Emp1";
                cmd.Connection = con;
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                MessageBox.Show("Rows=" + count);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ename from Emp where eid="+textBox1.Text;
                cmd.Connection = con;
                con.Open();
                label2.Text = cmd.ExecuteScalar().ToString() ;
                textBox1.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = 
                    "insert into Emp values (" +
                    textBox2.Text + ",'" + 
                    textBox3.Text + "'," + 
                    textBox4.Text + ")";
                cmd.Connection = con;
                con.Open();
                //Returns the number of rows affected
                int rows= cmd.ExecuteNonQuery();
                MessageBox.Show(rows + " added");
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =
                        "update Emp set ename = '" + 
                        textBox6.Text + "',basic=" + 
                        textBox5.Text +
                        " where eid=" + textBox7.Text;
                cmd.Connection = con;
                con.Open();
                //Returns the number of rows affected
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows + " updated");
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            #endregion
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Emp";
                cmd.Connection = con;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem row = new ListViewItem(dr[0].ToString());                    
                    row.SubItems.Add(dr[1].ToString());
                    row.SubItems.Add(dr[2].ToString());

                    listView1.Items.Add(row);
                    
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            #endregion
        }
    }
}
