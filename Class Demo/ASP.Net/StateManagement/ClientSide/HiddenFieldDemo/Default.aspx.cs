using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientSide_HiddenFieldDemo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (HiddenField1.Value.Length == 0)
            {
                HiddenField1.Value = TextBox1.Text;
            }
        }
        Literal1.Text = HiddenField1.Value;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = 0;
        if (NoOfClicks.Value.Length != 0)
        {
            count = int.Parse(NoOfClicks.Value);
        }
        count++;
        NoOfClicks.Value = count.ToString();
        Literal2.Text = NoOfClicks.Value;
    }
}