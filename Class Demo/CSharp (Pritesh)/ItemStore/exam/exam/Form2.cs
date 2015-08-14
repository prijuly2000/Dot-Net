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
    public partial class Form2 : Form
    {
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(ds);
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(ds);
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(ds);
            f5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COMP48;Initial Catalog=test;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from ItemStore", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
