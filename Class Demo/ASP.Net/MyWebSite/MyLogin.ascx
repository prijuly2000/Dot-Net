<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyLogin.ascx.cs" Inherits="MyLogin" %>
<style type="text/css">
    .style1
    {
        width: 39%;
        height: 72px;
    }
    .style2
    {
        width: 164px;
    }
    .style3
    {
        width: 83px;
    }
</style>

<table bgcolor="#FFCCCC" border="1" class="style1">
    <tr>
        <td class="style3">
            Login ID</td>
        <td class="style2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Password</td>
        <td class="style2">
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
        </td>
        <td class="style2">
            &nbsp;</td>
    </tr>
</table>

