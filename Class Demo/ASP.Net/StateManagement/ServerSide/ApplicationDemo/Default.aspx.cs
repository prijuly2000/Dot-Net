using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSide_ApplicationDemo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal2.Text = Application["count"].ToString();
        if (Application["data"] == null)
        {
            Literal1.Text = "Not Set";
        }
        else
        {
            Literal1.Text = Application["data"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Application.Lock();

        if (Application["data"] == null)
        {
            Application.Add("data", TextBox1.Text);
        }
        else
        {
            Application["data"] = TextBox1.Text;
        }

        Application.UnLock();

        //To remove the application variable
        //Application.Remove("data");
    }
}