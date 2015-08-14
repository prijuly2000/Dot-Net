using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       int  index = (int)Session["index"];
        DataSet ds = (DataSet)Session["ds"];
        DataRow dr=ds.Tables[0].Rows[index];
        dr.Delete();
        SqlDataAdapter da=(SqlDataAdapter)Session["da"];
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds);
        Response.Redirect("~/Display.aspx");
    }
}