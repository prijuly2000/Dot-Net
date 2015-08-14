using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //set the profile
        Profile.Personal.FirstName = TextBox1.Text;
        Profile.Personal.LastName = TextBox2.Text;
        Profile.Personal.DateOfBirth = Calendar1.SelectedDate;
        Profile.MyTheme = DropDownList1.SelectedValue;
        Profile.Course = TextBox3.Text;
        Profile.Center = new
            CenterDetails(TextBox4.Text, TextBox5.Text); ;

        Response.Redirect("~/Home.aspx");
    }
}