﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="facultypage.aspx.cs" Inherits="Faculty_facultypage" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <asp:HyperLink ID="HyperLink5" runat="server" Font-Size="Larger" 
        ForeColor="#CC0000" NavigateUrl="~/EditProfile.aspx" style="font-weight: 700">Edit Profile</asp:HyperLink>
</asp:Content>

<asp:Content ID="Content3" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Label ID="Label1" runat="server" Font-Names="Algerian" 
    Font-Size="XX-Large" ForeColor="#CC0000" Text="Welcome Faculty"></asp:Label>
</asp:Content>

