using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (MultiView1.ActiveViewIndex == 5)
        {
            MultiView1.ActiveViewIndex = 0;
        }
        else
        {
            MultiView1.ActiveViewIndex = 
                MultiView1.ActiveViewIndex + 1;
        }
    }
}