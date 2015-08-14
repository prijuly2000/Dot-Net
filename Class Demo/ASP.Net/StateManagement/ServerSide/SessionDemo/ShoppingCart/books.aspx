<%@ Page Language="C#" AutoEventWireup="true" CodeFile="books.aspx.cs" Inherits="ServerSide_SessionDemo_ShoppingCart_books" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 34%;
            height: 246px;
        }
    </style>
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
                        <asp:ListItem>Let Us C</asp:ListItem>
                        <asp:ListItem>ASP.Net Professional</asp:ListItem>
                        <asp:ListItem>C# for Beginners</asp:ListItem>
                        <asp:ListItem>Java Complete Ref</asp:ListItem>
                        <asp:ListItem>Mastering php</asp:ListItem>
                        <asp:ListItem>php In 1 Day</asp:ListItem>
                        <asp:ListItem>SE in 6 days</asp:ListItem>
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
