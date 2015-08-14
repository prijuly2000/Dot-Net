<%@ Page Language="C#" AutoEventWireup="true" CodeFile="second.aspx.cs" Inherits="ServerSide_SessionDemo_second" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Welcome :
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="~/ServerSide/SessionDemo/first.aspx">Go Back</asp:HyperLink>
    </form>
</body>
</html>
