using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal1.Text = FileUpload1.FileName;
        Literal1.Text += " Size=" + 
            FileUpload1.FileBytes.Length.ToString();
        //Logical path
        //server.MapPath converts logical 
        //path into physical path
        FileUpload1.SaveAs(Server.MapPath
            ("Uploads/"+FileUpload1.FileName));
       
    }
}