using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class createuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
        //This event occurs after user creation
         DropDownList dl = 
             (DropDownList)CreateUserWizard1.
             CreateUserStep.ContentTemplateContainer.
             FindControl("DropDownList1");
         Roles.AddUserToRole(CreateUserWizard1.UserName, 
             dl.SelectedValue);


    }
}