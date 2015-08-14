<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<<%@ OutputCache Duration="30" VaryByParam="none" %>
<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 41%;
            height: 65px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table bgcolor="#CCFFFF" border="1" class="style1">
            <tr>
                <td>
                    Cached Time</td>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>
                    Current Time</td>
                <td>
                    <asp:Substitution ID="Substitution1" runat="server" MethodName="GetTime" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
