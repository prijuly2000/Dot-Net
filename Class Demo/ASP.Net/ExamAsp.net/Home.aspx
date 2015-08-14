<%@ Page Title="" Language="C#"  MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content6" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <asp:HyperLink ID="HyperLink4" runat="server" 
        NavigateUrl="~/Student/EditProfile.aspx">Edit Profile</asp:HyperLink>
</asp:Content>
<asp:Content ID="Content7" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                        ID="Label1" runat="server" Text="Welcome to Home page" Font-Bold="True" 
                        Font-Italic="False" Font-Overline="True" Font-Size="X-Large" 
                        Font-Underline="True"></asp:Label>
                </asp:Content>



