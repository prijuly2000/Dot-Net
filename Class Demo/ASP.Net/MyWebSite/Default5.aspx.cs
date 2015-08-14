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
        string str = DateTime.Now.DayOfWeek.ToString();
        if (str == "Sunday" || str == "Saturday")
        {
            AdRotator1.KeywordFilter = "Fun";
            AdRotator2.KeywordFilter = "Fun";
            AdRotator3.KeywordFilter = "Fun";
            AdRotator4.KeywordFilter = "Fun";
        }
        else
        {
            AdRotator1.KeywordFilter = "Education";
            AdRotator2.KeywordFilter = "Education";
            AdRotator3.KeywordFilter = "Education";
            AdRotator4.KeywordFilter = "Education";
        }
    }
}