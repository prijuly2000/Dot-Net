using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class home : System.Web.UI.Page
{
    //Applying the profile
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Profile.MyTheme.Length != 0)
        {
            this.Theme = Profile.MyTheme;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Profile.Center != null)
        {
            TextBox1.Text = Profile.Personal.FirstName;
            TextBox2.Text = Profile.Personal.LastName;
            TextBox3.Text = Profile.Personal.DateOfBirth.ToShortDateString();
            TextBox4.Text = Profile.Course;
            TextBox5.Text = Profile.Center.CenterCode;
            TextBox6.Text = Profile.Center.CenterName;
        }
    }
}