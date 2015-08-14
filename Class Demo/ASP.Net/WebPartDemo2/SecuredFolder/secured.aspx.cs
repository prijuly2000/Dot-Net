using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class secured : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        switch (DropDownList1.SelectedValue)
        {
            case "Browse":
                WebPartManager1.DisplayMode = 
                    WebPartManager.BrowseDisplayMode;
                break;
            case "Catalog":
                WebPartManager1.DisplayMode = 
                    WebPartManager.CatalogDisplayMode;
                break;
            case "Design":
                WebPartManager1.DisplayMode =
                    WebPartManager.DesignDisplayMode;
                break;
            case "Edit":
                WebPartManager1.DisplayMode =
                    WebPartManager.EditDisplayMode;
                break;

        }
    }
}