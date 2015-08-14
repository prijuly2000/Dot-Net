<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="EditProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table border="1" style="height: 392px">
        <tr>
            <td style="width: 116px">
                Enter FirstName</td>
            <td style="width: 12px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Enter Last Name</td>
            <td style="width: 12px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Enter DateOfBirth</td>
            <td style="width: 12px">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                    ShowGridLines="True" Width="220px">
                    <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                    <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                    <OtherMonthDayStyle ForeColor="#CC9966" />
                    <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                    <SelectorStyle BackColor="#FFCC66" />
                    <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                        ForeColor="#FFFFCC" />
                    <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                </asp:Calendar>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Select Theme</td>
            <td style="width: 12px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>Winter</asp:ListItem>
                    <asp:ListItem>Summer</asp:ListItem>
                    <asp:ListItem>Spring</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Enter course</td>
            <td style="width: 12px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Enter CenterId</td>
            <td style="width: 12px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                Enter CenterName</td>
            <td style="width: 12px">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 116px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Update Profile" />
            </td>
            <td style="width: 12px">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

