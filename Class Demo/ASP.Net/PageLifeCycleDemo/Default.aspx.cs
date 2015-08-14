using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
        string str1 = this.IsPostBack.ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string str = TextBox1.Text;
    }
}