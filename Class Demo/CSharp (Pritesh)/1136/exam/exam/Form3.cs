﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataSet ds;
        public Form3(DataSet ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
       
        private void Form3_Load(object sender, EventArgs e)
        {
            if (ds.Tables.Count == 0)
            {
                SqlConnection con = new SqlConnection("Data Source=mba115;Initial Catalog=exam;Integrated Security=True;Pooling=False");
                SqlDataAdapter da = new SqlDataAdapter("select * from ItemStore", con);
                da.Fill(ds);
            }
            dataGridView1.DataSource=ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
            
        }

       
    }
}
