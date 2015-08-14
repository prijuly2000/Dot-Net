<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
                        <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                            Font-Size="XX-Large" ForeColor="#006699" 
        Text="Welcome"></asp:Label>
                    </asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/faculty.aspx" 
        style="font-weight: 700">Faculty Page</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/student.aspx" 
        style="font-weight: 700">Student Page</asp:HyperLink>
    <br />
    <br />
    <br />
    <br />
</asp:Content>


