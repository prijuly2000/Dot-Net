using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class first : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        Literal1.Text = str;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        Literal1.Text = str;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        Literal1.Text = str;
    }
}