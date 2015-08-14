<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdRotatorDemo.aspx.cs" Inherits="AdRotatorDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:AdRotator ID="AdRotator1" runat="server" 
            AdvertisementFile="~/adXaml.xml" />
        <asp:AdRotator ID="AdRotator2" runat="server" 
            AdvertisementFile="~/adXaml.xml" />
        <asp:AdRotator ID="AdRotator3" runat="server" 
            AdvertisementFile="~/adXaml.xml" />
        <asp:AdRotator ID="AdRotator4" runat="server" 
            AdvertisementFile="~/adXaml.xml" />
    
    </div>
    </form>
</body>
</html>
