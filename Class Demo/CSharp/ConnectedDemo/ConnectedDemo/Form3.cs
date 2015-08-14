using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ConnectedDemo
{
    public partial class Form3 : Form
    {
        OracleConnection con;
        OracleCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region connection
            try
            {
                con = new OracleConnection();
                con.ConnectionString = "Data Source=orcl.iacsd.org;User ID=user101;Password=user101;Unicode=True";
                cmd = new OracleCommand();


                cmd.CommandType = CommandType.Text;
                //Provide the name of stored procedu  re
                cmd.CommandText = "select * from Emp";


                cmd.Connection = con;
                con.Open();
                MessageBox.Show(" Number of Rows =" + cmd.ExecuteScalar().ToString());

            }
            catch (OracleException ex)
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
