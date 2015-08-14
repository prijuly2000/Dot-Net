using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class ServerSide_SessionDemo_Database_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //First Request
        if (!IsPostBack)
        {
            SqlConnection con = new SqlConnection(@"Data Source=CLASSROOM;Initial Catalog=Company1;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select * from Emp", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Session.Add("MyData", ds);
            Session.Add("Count", 0);
            TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
            TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = (int)Session["count"];
        DataSet ds = (DataSet)Session["MyData"];
        int max = ds.Tables[0].Rows.Count;
        Button b1 = (Button)sender;
        switch (b1.Text)
        {
            case "First":
                count = 0;
                break;
            case "Prev":
                if (count > 0)
                {
                    count--;
                }
                break;
            case "Next":
                if (count < max - 1)
                {
                    count++;
                }
                break;
            case "Last":
                count = max - 1;
                break;
        }
        Session["count"] = count;
        TextBox1.Text = ds.Tables[0].Rows[count][0].ToString();
        TextBox2.Text = ds.Tables[0].Rows[count][1].ToString();
        TextBox3.Text = ds.Tables[0].Rows[count][2].ToString();
        
    }
}