<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="engg.aspx.cs" Inherits="engg" %>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                            Font-Size="XX-Large" ForeColor="#006699" 
    Text="Engineering"></asp:Label>
                    </asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/civil.aspx" 
    style="font-weight: 700">Civil</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/mechanical.aspx" 
    style="font-weight: 700">Mechanical</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/electrical.aspx" 
    style="font-weight: 700">Electrical</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/comp.aspx" 
    style="font-weight: 700">Computer Sc</asp:HyperLink>
</asp:Content>


