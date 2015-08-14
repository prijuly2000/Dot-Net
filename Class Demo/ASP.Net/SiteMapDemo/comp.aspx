<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="comp.aspx.cs" Inherits="comp" %>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
                            Font-Size="XX-Large" ForeColor="#006699" 
    Text="Computer Science"></asp:Label>
                    </asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/firstyear.aspx" 
    style="font-weight: 700">First Year</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/secondyear.aspx" 
    style="font-weight: 700">Second Year</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/thirdyear.aspx" 
    style="font-weight: 700">Third Year</asp:HyperLink>
<br />
<br />
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/be.aspx" 
    style="font-weight: 700">Final Year</asp:HyperLink>
</asp:Content>


