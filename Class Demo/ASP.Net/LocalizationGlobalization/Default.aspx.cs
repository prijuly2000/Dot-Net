using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

using System.Globalization; //CultureInfo
using Resources; //Messages (Satelite assembly)

public partial class _Default : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        base.InitializeCulture();
        //To set the Culture and UI culture
        if (Request["Language"] != null)
        {
            Thread.CurrentThread.CurrentCulture = 
                new CultureInfo(Request.QueryString["Language"]);
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo(Request.QueryString["Language"]);
        }

    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = Messages.Greeting;
        Label3.Text = Messages.Reply;
        Label4.Text = Messages.Regards;
    }
}