﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="secured.aspx.cs" Inherits="secured" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
            Font-Size="XX-Large" ForeColor="Red" Text="Secured Page"></asp:Label>
    
    </div>
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LoginName ID="LoginName1" runat="server" />
    </form>
</body>
</html>
