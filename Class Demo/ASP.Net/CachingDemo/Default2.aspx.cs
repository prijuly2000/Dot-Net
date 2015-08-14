using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal1.Text = DateTime.Now.ToLongTimeString();
    }

    public static string GetTime(HttpContext con)
    {
        //This will be set as the text of Subsitution control
        return DateTime.Now.ToLongTimeString();        
    }
}