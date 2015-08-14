using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = GridView1.Rows.Count;
        for (int i = 0; i < count; i++)
        {
            CheckBox chk=(CheckBox)GridView1.Rows[i].Cells[0].
                FindControl("CheckBox1");
            if (chk.Checked)
            {
                ListBox1.Items.Add(GridView1.Rows[i].Cells[2].Text);
            }
        }
    }
}