using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tablecondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COMP48;Initial Catalog=test;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from itemstore",con);
            DataSet ds = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
        }
    }
}
