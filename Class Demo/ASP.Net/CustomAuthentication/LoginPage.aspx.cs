using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        //database connection code <u have to write> (for custom authentication)
        //uname,pwd
        string str = "select * from UserInfo where username='" + 
            Login1.UserName + "' and password='" + 
            Login1.Password + "'";
        //if valid 
        Response.Redirect("secured.aspx");
        //else
        Response.Redirect("loginpage.aspx");

    }
}