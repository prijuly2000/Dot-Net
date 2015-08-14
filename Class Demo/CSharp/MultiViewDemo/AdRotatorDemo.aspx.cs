using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdRotatorDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str=DateTime.Now.DayOfWeek.ToString();
        if (str == "Sunday" || str == "Saturday")
        {
            AdRotator1.KeywordFilter = "topic1";
            AdRotator2.KeywordFilter="topic1";
            AdRotator3.KeywordFilter = "topic1";
            AdRotator4.KeywordFilter = "topic1";

        }
        else
        {
            
        }
    }
}