using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyLogin : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(TextBox1.Text=="iacsd" && TextBox2.Text=="welcome")
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            Response.Redirect("Default6.aspx");
        }
    }
}