using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=comp48;Initial Catalog=database1;Integrated Security=True;Pooling=False";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Student";
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds=new DataSet();

        da.Fill(ds);
        Session["ds"] = ds;
        Session["da"] = da;

    }
    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}