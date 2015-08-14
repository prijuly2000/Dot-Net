using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        if (CheckBox1.Checked)
        {
            string str = "Dear " + TextBox1.Text + " " + 
                TextBox2.Text + ", your ticket from";
            str += DropDownList2.SelectedValue +
                " to " + DropDownList1.SelectedValue;
            str += " on " + 
                Calendar1.SelectedDate.ToShortDateString() + 
                " for " + DropDownList3.SelectedValue;
            str += " people has been booked";
            Label1.Text = str;
        }
        else
        {
            Label1.Text = "Please visit again";
        }

    }
}