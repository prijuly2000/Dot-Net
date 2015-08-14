using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClientSide_ViewStateDemo_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            if (ViewState.Count == 0)
            {
                ViewState.Add("uname", TextBox1.Text);
            }
            Literal1.Text = ViewState["uname"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int count = 0;
        if (ViewState["count"] != null)
        {
            count = (int)ViewState["count"];
        }
        else
        {
            //Must use this method for adding new item
            ViewState.Add("count", count);
        }
        count++;
        //for modifying existing item
        ViewState["count"] = count;
        Literal2.Text = ViewState["count"].ToString();
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox2.Text);
    }
}