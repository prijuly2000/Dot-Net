using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label2.Text = TextBox1.Text;
        Literal1.Text = TextBox1.Text;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox2.Text);
        TextBox2.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int i = 
            RadioButtonList1.SelectedIndex;
        switch (i)
        {
            case 0:
                this.Button4.BackColor = Color.Red;
                break;
            case 1:
                this.Button4.BackColor = Color.Green;
                break;
            case 2:
                this.Button4.BackColor = Color.Blue;
                break;

        }
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int i =
           RadioButtonList1.SelectedIndex;
        switch (i)
        {
            case 0:
                this.Button4.BackColor = Color.Red;
                break;
            case 1:
                this.Button4.BackColor = Color.Green;
                break;
            case 2:
                this.Button4.BackColor = Color.Blue;
                break;

        }
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = "";
        for(int i=0;i<CheckBoxList1.Items.Count;i++)
        {
            if (CheckBoxList1.Items[i].Selected)
            {
                str += CheckBoxList1.Items[i].Value;
            }
        }
        Label3.Text = str;
    }
}