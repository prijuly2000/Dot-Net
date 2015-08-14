<%@ Page Title="" Theme="Holidays" Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin_Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>


<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder4">
    <asp:LinkButton ID="LinkButton1"  runat="server"  onclick="LinkButton1_Click" 
    PostBackUrl="~/Admin/AddStudent.aspx">Add Student</asp:LinkButton>
<br />
<br />
<asp:LinkButton ID="LinkButton2" runat="server" 
    PostBackUrl="~/Admin/DisplayStudent.aspx">Display Student</asp:LinkButton>
<br />
<br />
<asp:HyperLink ID="HyperLink4" runat="server" 
        NavigateUrl="~/Student/EditProfile.aspx">Edit Profile</asp:HyperLink>
</asp:Content>



<asp:Content ID="Content4" runat="server" 
    contentplaceholderid="ContentPlaceHolder2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                        ID="Label1" runat="server" Text="Welcome to Admin page" Font-Bold="True" 
                        Font-Italic="False" Font-Overline="True" Font-Size="X-Large" 
                        Font-Underline="True"></asp:Label>
                </asp:Content>




<asp:Content ID="Content5" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
        
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        
        </asp:Content>





