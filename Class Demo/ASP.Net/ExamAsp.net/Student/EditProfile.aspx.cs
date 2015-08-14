using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditProfile : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
    {
        
    }

    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session.Add("theme", DropDownList1.SelectedValue);
        Profile.Theme = DropDownList1.SelectedValue;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.Add("theme", DropDownList1.SelectedValue);
        Profile.Theme = DropDownList1.SelectedValue;
        Profile.Name = TextBox1.Text;
        Response.Redirect(@"~/Home.aspx");
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}