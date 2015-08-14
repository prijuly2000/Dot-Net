<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            width: 159px;
        }
    </style>
</head>
<body bgcolor="#ffcccc">
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Display Time" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                Enter Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Display Time" />
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="138px" 
                    ImageUrl="~/Images/Sunset.jpg" Width="158px" />
            </td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;<asp:HyperLink 
                    ID="HyperLink1" runat="server" NavigateUrl="~/second.aspx">Next Page</asp:HyperLink>
                </strong>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
&nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                    Text="Add To List" />
            </td>
            <td>
                &nbsp;&nbsp; &nbsp;<asp:ListBox ID="ListBox1" runat="server" Height="124px" Width="135px">
                </asp:ListBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
                    <asp:ListItem>Red</asp:ListItem>
                    <asp:ListItem>Green</asp:ListItem>
                    <asp:ListItem>Blue</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
            <td>
                <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
                    Text="Display" 
                    style="top: 421px; left: 211px; height: 26px; width: 63px" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
                    <asp:ListItem>C Programming</asp:ListItem>
                    <asp:ListItem>CPP Programming</asp:ListItem>
                    <asp:ListItem>Java </asp:ListItem>
                    <asp:ListItem>.Net</asp:ListItem>
                    <asp:ListItem>WP-XML</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
