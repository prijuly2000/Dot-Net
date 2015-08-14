<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FirstPage.aspx.cs" Inherits="Redirect_FirstPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>First Page</h1>
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Response.Redirect" />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Server.Transfer" />
    </form>
</body>
</html>
