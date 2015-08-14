using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientSide_CookiesDemo_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["uname"] != null)
        {
            Literal2.Text = Request.Cookies["uname"].Value;
        }
        else
        {
            Literal2.Text = "Guest";
        }

        if (Request.Cookies["course"] != null)
        {
            Literal3.Text = Request.Cookies["course"].Value;
        }
        else
        {
            Literal3.Text = "Not Set";
        }
    }
}