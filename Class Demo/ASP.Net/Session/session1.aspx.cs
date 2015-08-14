using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class session1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["data"] == null)
        {
            Literal1.Text = "not set";


        }
        else
        {
            Literal1.Text = Session["data"].ToString();
            Literal2.Text = Session.SessionID; 
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["data"] == null)
        {
            Session.Add("data", TextBox1.Text);

        }
        else
        {
            Session["data"] = TextBox1.Text;  
        }
    }
}