<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="student.aspx.cs" Inherits="student" %>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                            Font-Size="XX-Large" ForeColor="#006699" 
    Text="Student Page"></asp:Label>
                    </asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/bca.aspx" 
    style="font-weight: 700">BCA</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/bsc.aspx" 
    style="font-weight: 700">BSC</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/mca.aspx" 
    style="font-weight: 700">MCA</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/engg.aspx" 
    style="font-weight: 700">Engineering</asp:HyperLink>
</asp:Content>


