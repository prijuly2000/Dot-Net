using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DisplayStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds;
        if (Session["ds"] == null)
        {
            SqlConnection con = new SqlConnection(@"Data Source=comp48;Initial Catalog=student;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            ds = new DataSet();
            da.Fill(ds);
            Session.Add("ds", ds);

        }
        else
        {
            ds = (DataSet)Session["ds"];
        }
        GridView1.DataSource = ds;
        GridView1.DataMember = ds.Tables[0].TableName;
        GridView1.DataBind();
        
       
    }

   
}