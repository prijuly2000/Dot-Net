<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cds.aspx.cs" Inherits="ServerSide_SessionDemo_ShoppingCart_cds" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="style1" align="center" bgcolor="#99FFCC" border="1">
            <tr align="center">
                <td>
                    Select the Books</td>
            </tr>
            <tr align="center">
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" Height="122px" Width="165px">
                        <asp:ListItem>VS2010</asp:ListItem>
                        <asp:ListItem>Age Of Empires</asp:ListItem>
                        <asp:ListItem>Windows 7</asp:ListItem>
                        <asp:ListItem>Counter Strike</asp:ListItem>
                        <asp:ListItem>Fifa</asp:ListItem>
                        <asp:ListItem>NFS</asp:ListItem>
                        <asp:ListItem>Angry Ninja</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Add To cart" 
                        onclick="Button1_Click" />
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:HyperLink ID="HyperLink2" runat="server" 
                        NavigateUrl="~/ServerSide/SessionDemo/ShoppingCart/home.aspx">HOME</asp:HyperLink>
                </td>
            </tr>
            <tr align="center">
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
