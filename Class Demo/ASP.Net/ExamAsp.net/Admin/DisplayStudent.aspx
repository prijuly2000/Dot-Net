<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="DisplayStudent.aspx.cs" Inherits="DisplayStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style2
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                        ID="Label1" runat="server" 
        Text="Welcome to Display Student page" Font-Bold="True" 
                        Font-Italic="False" Font-Overline="True" Font-Size="X-Large" 
                        Font-Underline="True"></asp:Label>
                </asp:Content>
<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <table class="style1" style="height: 173px; width: 91%">
        <tr>
            <td colspan="2" >
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style2">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
        
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        
        </asp:Content>


