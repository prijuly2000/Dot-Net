using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class First : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Literal1.Text = DateTime.Now.ToLongTimeString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Literal2.Text = DropDownList1.SelectedValue;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Literal3.Text = TextBox1.Text;
    }
}