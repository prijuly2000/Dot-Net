using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSide_SessionDemo_ShoppingCart_finish : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList arr;
        if (Session["Cart"] == null)
        {
            ListBox1.Items.Add("No Item Selected...");
        }
        else
        {

            arr = (ArrayList)Session["Cart"];
            foreach (object obj in arr)
            {
                ListBox1.Items.Add(obj.ToString());
            }
        }
    }
}