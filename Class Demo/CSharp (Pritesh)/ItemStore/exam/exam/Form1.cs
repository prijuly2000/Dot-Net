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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userControl11_Click(object sender, EventArgs e)
        {
            #region 1
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=mba91;Initial Catalog=exam;Integrated Security=True;Pooling=False";
            //string uid = userControl11.Username;
            //string pwd = userControl11.Passwrod;
           
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from userinfo";
            //cmd.Connection = con;
            //con.Open();
           
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    if (dr[0].ToString() == uid && dr[1].ToString() == pwd)
            //    {
            //        MessageBox.Show("success");
            //        Form2 f2 = new Form2();
            //        f2.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("failed sory");
            //    }
            //}
            #endregion 

            SqlConnection con = new SqlConnection("Data Source=COMP48;Initial Catalog=test;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select count(*) from userinfo where username='" + userControl11.Username + "' and password='" + userControl11.Passwrod + "'";

            cmd.Connection = con;
            con.Open();
            int count;//= 1;
            count = (int)cmd.ExecuteScalar();
            
                     
            
            if (count == 1)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            con.Close();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        
    }
}
