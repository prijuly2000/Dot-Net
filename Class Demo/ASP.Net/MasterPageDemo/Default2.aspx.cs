using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string day = DateTime.Now.DayOfWeek.ToString();
        if (day == "Saturday" || day == "Sunday")
        {
            this.MasterPageFile = "First.Master";
        }
        else
        {
            this.MasterPageFile = "Second.Master";
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}