using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["ds"] != null)
        {
            DataSet ds = (DataSet)Session["ds"];
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = TextBox1.Text;
            dr[1] = TextBox2.Text;
            dr[2] = TextBox3.Text;
            dr[3] = TextBox4.Text;
            ds.Tables[0].Rows.Add(dr);
        }
        else
        {
            Response.Write("Cannot insert, Go to display page first");
        }
        

    }
}