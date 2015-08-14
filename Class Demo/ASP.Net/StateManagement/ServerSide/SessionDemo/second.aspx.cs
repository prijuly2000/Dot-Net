using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSide_SessionDemo_second : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["data"] == null)
        {
            Literal1.Text = "Not Set";
        }
        else
        {
            Literal1.Text = Session["data"].ToString();
        }
    }
}