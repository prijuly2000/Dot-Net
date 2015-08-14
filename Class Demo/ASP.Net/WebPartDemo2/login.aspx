<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
            Font-Size="XX-Large" ForeColor="#00CC66" Text="Login Page"></asp:Label>
    
    </div>
    <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" 
        BorderStyle="Solid" BorderWidth="1px" CreateUserText="New User" 
        CreateUserUrl="~/registeruser.aspx" Font-Names="Verdana" Font-Size="10pt" 
        Height="149px" Width="250px">
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:Login>
    </form>
</body>
</html>
