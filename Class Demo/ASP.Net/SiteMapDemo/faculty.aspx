<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="faculty.aspx.cs" Inherits="faculty" %>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
                        <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                            Font-Size="XX-Large" ForeColor="#006699" 
        Text="Faculty Page"></asp:Label>
                    </asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/admin.aspx" 
        style="font-weight: 700">Admin Page</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/technical.aspx" 
        style="font-weight: 700">Technical Page</asp:HyperLink>
    <br />
    <br />
    <br />
    <br />
</asp:Content>


