using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientSide_CookiesDemo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["uname"] != null)
        {
            Literal1.Text = Request.Cookies["uname"].Value;
        }
        else
        {
            Literal1.Text = "Guest";
        }

        if (Request.Cookies["course"] != null)
        {
            Literal2.Text = Request.Cookies["course"].Value;
        }
        else
        {
            Literal2.Text = "Not Set";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies["uname"].Value = TextBox1.Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Cookies["course"].Value = TextBox2.Text;
        Response.Cookies["course"].Expires =
            DateTime.Now.AddMinutes(5);


        //Delete the cookie
       // Response.Cookies["course"].Expires =
        //    DateTime.Now.AddMinutes(-1);
    }
}