<%@ Page Language="C#" AutoEventWireup="true" CodeFile="second.aspx.cs" Inherits="second" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 257px;
        }
    </style>
</head>
<body bgcolor="#99ccff">
    <form id="form1" runat="server">
    <div>
    <h1 style="color: #800080"> Second Page</h1>
    </div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Back</asp:HyperLink>
    <table class="style1">
        <tr>
            <td class="style2">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
                    BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
                    Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
                    onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
                    Width="220px">
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
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <br />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:BulletedList ID="BulletedList1" runat="server" 
                    BulletImageUrl="~/Images/Sunset.jpg" BulletStyle="Numbered">
                    <asp:ListItem>.Net Framework</asp:ListItem>
                    <asp:ListItem>CSharp</asp:ListItem>
                    <asp:ListItem>ASP.Net</asp:ListItem>
                    <asp:ListItem>VB.Net</asp:ListItem>
                </asp:BulletedList>
            </td>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="59px" 
                    ImageUrl="~/Images/Winter.jpg" onclick="ImageButton1_Click" Width="82px" />
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                    PostBackUrl="~/second.aspx">LinkButton</asp:LinkButton>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
