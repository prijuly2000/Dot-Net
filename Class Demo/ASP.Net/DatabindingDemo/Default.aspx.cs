using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False");
        SqlCommand cmd = new SqlCommand("Select * from Emp", con);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);



        //Programmatic binding of datasource
        GridView1.DataSource = ds;
        GridView1.DataBind();

    }
}