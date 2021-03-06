﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vaishali
{
    public partial class GridView : System.Web.UI.Page
    {
        DataSet ds;
        SqlConnection con;
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=CDAC_Vaishali;Integrated Security=True;Pooling=False";
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from Table1";
            com.Connection = con;

             da = new SqlDataAdapter(com);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds);
            
            GridView1.DataSource=ds;
            GridView1.DataMember = ds.Tables[0].TableName;
            GridView1.AutoGenerateDeleteButton = true;
            GridView1.DataBind();
            
               
            
        }

        protected void GridView1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                GridView1.Rows[i].Cells[1].Text = (i+1).ToString();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            ds.Tables[0].Rows[int.Parse(e.Values[0].ToString()) - 1].Delete();
            
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[0]);
                        
            GridView1.DataBind();
            GridView1_Load(sender, e);
                       
        }
    }
}