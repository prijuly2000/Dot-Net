using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class First : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string str = DateTime.Now.DayOfWeek.ToString();
        if (str == "Saturday" || str == "Sunday")
        {
            this.MasterPageFile = "Master1.master";
            this.Theme = "hot";

        }
        else
        {
            this.MasterPageFile = "Master2.master";
            this.Theme = "hot2";
        }

    }
    
}