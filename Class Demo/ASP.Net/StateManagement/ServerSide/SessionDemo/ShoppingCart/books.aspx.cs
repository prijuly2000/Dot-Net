using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServerSide_SessionDemo_ShoppingCart_books : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ArrayList arr;
        if (Session["Cart"] == null)
        {
            arr = new ArrayList();
            Session.Add("Cart", arr);
        }
        arr = (ArrayList)Session["Cart"];
        arr.Add(ListBox1.SelectedValue);
        Literal1.Text = ListBox1.SelectedValue + " add to Cart";
        Literal2.Text = arr.Count.ToString() + " items in cart";
    }
}