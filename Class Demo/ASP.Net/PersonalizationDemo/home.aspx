<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label2" runat="server" Text="FirstName"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td rowspan="6">
                <asp:Image ID="Image1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label3" runat="server" Text="LastName"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label4" runat="server" Text="DateOfBirth"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label5" runat="server" Text="Course"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label6" runat="server" Text="CenterId"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 81px">
                <asp:Label ID="Label7" runat="server" Text="CenterName"></asp:Label>
            </td>
            <td style="width: 139px">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
    Font-Size="XX-Large" ForeColor="#CC0000" Text="HOME Page"></asp:Label>
</asp:Content>


