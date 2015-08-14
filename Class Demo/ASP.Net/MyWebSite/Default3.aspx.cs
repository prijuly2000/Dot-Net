using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = DateTime.Now.DayOfWeek.ToString();
        switch (str)
        {
            case "Monday":
                MultiView1.ActiveViewIndex = 0;
                break;
            case "Tuesday":
                MultiView1.ActiveViewIndex = 1;
                break;
            case "Wednesday":
                MultiView1.ActiveViewIndex = 2;
                break;

        }

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 
            DropDownList1.SelectedIndex;
    }
}