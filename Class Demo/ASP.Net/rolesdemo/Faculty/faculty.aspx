<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="faculty.aspx.cs" Inherits="faculty" %>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <table border="1" cellspacing="0" class="style1">
    <tr>
        <td colspan="3">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Welcome To Faculty Page"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td width="25">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Admin/Admin.aspx">Admin</asp:HyperLink>
        </td>
        <td rowspan="3" width="50">
            &nbsp;</td>
        <td>
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink2" runat="server" 
                NavigateUrl="~/Faculty/faculty.aspx">Faculty</asp:HyperLink>
        </td>
        <td>
            <asp:LoginName ID="LoginName1" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:HyperLink ID="HyperLink3" runat="server" 
                NavigateUrl="~/Student/student.aspx">Student</asp:HyperLink>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

