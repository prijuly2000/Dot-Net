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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                //Provide the name of stored procedure
                cmd.CommandText = "DisplayCount";
                
                
                cmd.Connection = con;
                con.Open();
                MessageBox.Show(" Number of Rows ="+cmd.ExecuteScalar().ToString());
                
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
                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DisplayAll";
               
                
                
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

        private void button2_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False";
                cmd = new SqlCommand();


                cmd.CommandType = CommandType.StoredProcedure;
                //Provide the name of stored procedure
                cmd.CommandText = "GetName";

                SqlParameter p1 = new SqlParameter();
                p1.DbType = DbType.Int32;
                p1.Value = textBox1.Text;
                
                p1.ParameterName = "@pm1";
                cmd.Parameters.Add(p1);
                cmd.Connection = con;
                con.Open();
                MessageBox.Show("Name ="+ cmd.ExecuteScalar().ToString());

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


                cmd.CommandType = CommandType.StoredProcedure;
                //Provide the name of stored procedure
                cmd.CommandText = "InsertEmp";

                SqlParameter p1 = new SqlParameter();
                p1.DbType = DbType.Int32;
                p1.Value = textBox2.Text;
                p1.ParameterName = "@pm1";

                SqlParameter p2 = new SqlParameter();
                p2.DbType = DbType.String;
                p2.Value = textBox3.Text;
                p2.ParameterName = "@pm2";
                p2.Size = 20;

                SqlParameter p3 = new SqlParameter();
                p3.DbType = DbType.Double;
                p3.Value = textBox4.Text;
                p3.ParameterName = "@pm3";              
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Connection = con;
                con.Open();
                int rows= cmd.ExecuteNonQuery();
                MessageBox.Show(rows + " updated");

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
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                //Provide the name of stored procedure
                cmd.CommandText = "AcceptName";

                SqlParameter p1 = new SqlParameter();
                p1.DbType = DbType.Int32;
                p1.Value = textBox5.Text;
                p1.ParameterName = "@pm1";

                ////////////Output parameter
                SqlParameter p2 = new SqlParameter();
                p2.DbType = DbType.String;
                p2.Size = 20;
                p2.Direction = ParameterDirection.Output;
                p2.ParameterName = "@pm2";
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show(p2.Value.ToString());

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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
