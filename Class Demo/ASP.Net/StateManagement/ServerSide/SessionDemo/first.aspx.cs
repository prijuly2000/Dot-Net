using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSide_SessionDemo_first : System.Web.UI.Page
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

            Literal2.Text = Session.SessionID;
            Literal3.Text = Session.Timeout.ToString();
            Session.Timeout = 4;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["data"] == null)
        {
            //creating
            Session.Add("data", TextBox1.Text);
        }
        else
        {
            //modifying
            Session["data"] = TextBox1.Text;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Remove("data");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       //To terminate the session
        Session.Abandon();
    }
}