﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{

    protected void Page_PreInit(object sender, EventArgs e)
    {
       
        if (Profile.Theme!= null)
        {
            this.Theme = Profile.Theme;
            
        }

    }   

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }          
}