using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate
        (object source, ServerValidateEventArgs args)
    {
        //args.Value => Value of TextBox
        int x =int.Parse(args.Value);
        if (x % 2 == 0 && x > 20)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false; //Display the error msg
        }
    }
}