<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="ServerSide_SessionDemo_ShoppingCart_home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/ServerSide/SessionDemo/ShoppingCart/books.aspx">Books</asp:HyperLink>
    
    </div>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" 
            NavigateUrl="~/ServerSide/SessionDemo/ShoppingCart/cds.aspx">CDs</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/ServerSide/SessionDemo/ShoppingCart/mobile.aspx">Mobile</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink4" runat="server" 
            NavigateUrl="~/ServerSide/SessionDemo/ShoppingCart/finish.aspx">Billing</asp:HyperLink>
    </p>
    </form>
</body>
</html>
