<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mobile.aspx.cs" Inherits="ServerSide_SessionDemo_ShoppingCart_mobile" %>

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
                        <asp:ListItem>Nokia Asha</asp:ListItem>
                        <asp:ListItem>Samsung Champ</asp:ListItem>
                        <asp:ListItem>Samsung Galaxzy</asp:ListItem>
                        <asp:ListItem>Lava</asp:ListItem>
                        <asp:ListItem>Nokia Lumia</asp:ListItem>
                        <asp:ListItem>Karbon</asp:ListItem>
                        <asp:ListItem>Lemon</asp:ListItem>
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
