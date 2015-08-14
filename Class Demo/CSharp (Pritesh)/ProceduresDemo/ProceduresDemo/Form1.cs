using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProceduresDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=comp48;Initial Catalog=database1;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DispName";
            cmd.Connection = con;

            SqlParameter p1 = new SqlParameter();
            p1.DbType = DbType.Int32;
            p1.ParameterName = "@pm1";
            p1.Value = textBox1.Text;

            SqlParameter p2 = new SqlParameter();
            p2.DbType = DbType.String;
            p2.ParameterName = "@pm2";
            p2.Direction = ParameterDirection.Output;
            p2.Size = 20;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            label2.Text = p2.Value.ToString();

        }
    }
}
