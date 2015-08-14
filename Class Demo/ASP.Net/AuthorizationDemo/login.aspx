<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:Login ID="Login1" runat="server" CreateUserText="Sign In" 
    CreateUserUrl="~/createuser.aspx" Height="152px" Width="224px">
</asp:Login>
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
    Font-Size="XX-Large" ForeColor="#CC0000" Text="Please Login"></asp:Label>
</asp:Content>


